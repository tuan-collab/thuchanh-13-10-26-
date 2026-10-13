using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace QuanLySinhVien
{
   
    public class Student : INotifyPropertyChanged
    {
        private string _id = "", _name = "", _gender = "Nam", _avatar = "";
        private int _age = 18;

        public string StudentId { get => _id; set { _id = value; OnChanged(); } }
        public string FullName { get => _name; set { _name = value; OnChanged(); } }
        public int Age { get => _age; set { _age = value; OnChanged(); } }
        public string Gender { get => _gender; set { _gender = value; OnChanged(); } }
        public string AvatarPath { get => _avatar; set { _avatar = value; OnChanged(); } }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnChanged([CallerMemberName] string? p = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(p));
    }
}