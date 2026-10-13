using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLySinhVien
{
    
    public partial class FormStudent : Form
    {
        private readonly BindingList<Student> _list = new BindingList<Student>();
        private readonly BindingSource _bs = new BindingSource();

        public FormStudent()
        {
            InitializeComponent();  
            SetupBinding();
        }

        private void SetupBinding()
        {
            _bs.DataSource = _list;
            dgv.DataSource = _bs;

            txtId.DataBindings.Add("Text", _bs, nameof(Student.StudentId), true, DataSourceUpdateMode.OnPropertyChanged);
            txtName.DataBindings.Add("Text", _bs, nameof(Student.FullName), true, DataSourceUpdateMode.OnPropertyChanged);
            txtAge.DataBindings.Add("Text", _bs, nameof(Student.Age), true, DataSourceUpdateMode.OnPropertyChanged);
            cboGender.DataBindings.Add("Text", _bs, nameof(Student.Gender), true, DataSourceUpdateMode.OnPropertyChanged);

            _bs.CurrentChanged += (s, e) => LoadAvatar();   

            _list.Add(new Student { StudentId = "SV001", FullName = "Nguyễn Văn An", Age = 20, Gender = "Nam" });
            _list.Add(new Student { StudentId = "SV002", FullName = "Trần Thị Bình", Age = 19, Gender = "Nữ" });
        }

        private void LoadAvatar()
        {
            pic.Image?.Dispose();
            pic.Image = null;
            if (_bs.Current is Student st && File.Exists(st.AvatarPath))
            {
                using var fs = new FileStream(st.AvatarPath, FileMode.Open, FileAccess.Read);
                using var ms = new MemoryStream();
                fs.CopyTo(ms);
                pic.Image = Image.FromStream(ms);
            }
        }

        private void btnPick_Click(object? sender, EventArgs e)
        {
            if (_bs.Current is not Student st) return;
            using var ofd = new OpenFileDialog { Filter = "Hình ảnh|*.jpg;*.jpeg;*.png;*.bmp" };
            if (ofd.ShowDialog() != DialogResult.OK) return;
            st.AvatarPath = ofd.FileName;
            LoadAvatar();
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            _list.Add(new Student { StudentId = "SV" + (_list.Count + 1).ToString("000"), FullName = "Sinh viên mới" });
            _bs.Position = _list.Count - 1;
        }

        private void btnDel_Click(object? sender, EventArgs e)
        {
            if (_bs.Current is not Student st) return;
            if (MessageBox.Show($"Xóa {st.FullName}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                _bs.RemoveCurrent();
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            _bs.EndEdit();
            _bs.ResetCurrentItem();
        }

        private void btnCsv_Click(object? sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog { Filter = "CSV|*.csv", FileName = "students.csv" };
            if (sfd.ShowDialog() != DialogResult.OK) return;

            var sb = new StringBuilder();
            sb.AppendLine("StudentId,FullName,Age,Gender,AvatarPath");
            foreach (var s in _list)
                sb.AppendLine(string.Join(",", Csv(s.StudentId), Csv(s.FullName), s.Age, Csv(s.Gender), Csv(s.AvatarPath)));

            File.WriteAllText(sfd.FileName, sb.ToString(), new UTF8Encoding(true)); 
            MessageBox.Show("Đã xuất file: " + sfd.FileName);
        }

        private static string Csv(string v)
            => v.Contains(',') || v.Contains('"') || v.Contains('\n') ? "\"" + v.Replace("\"", "\"\"") + "\"" : v;
    }
}