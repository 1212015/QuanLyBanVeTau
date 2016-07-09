using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class UsersDTO
    {
        private int _UserId;
        private int _GroupId;
        private string _UserName;
        private string _Password;
        private string _Email;
        private DateTime _AddedDate;
        private string _Actived;
        private string _Locked;
        //Phương thức khởi tạo mặc định
        public UsersDTO()
        {
            _UserId=0;
            _GroupId=0;
            _UserName="";
            _Password="";
            _Email="";
            _AddedDate=DateTime.Today;
            _Actived="";
            _Locked = "";
        }

        //Phương thức khởi tạo có tham số
        public UsersDTO(int UserId, int GroupId, string UserName,string Password, string Email,DateTime AddedDate, string Actived, string Locked)
        {
            _UserId = UserId;
            _GroupId = GroupId;
            _UserName = UserName;
            _Password = Password;
            _Email = Email;
            _AddedDate = AddedDate;
            _Actived = Actived;
            _Locked = Locked;
        }

        //Phương thức khởi tạo có tham số
        public UsersDTO(int UserId, int GroupId, string UserName, string Password, string Email, DateTime AddedDate, string Actived)
        {
            _UserId = UserId;
            _GroupId = GroupId;
            _UserName = UserName;
            _Password = Password;
            _Email = Email;
            _AddedDate = AddedDate;
            _Actived = Actived;
        }

        //Phương thức khởi tạo sao chép.
        public UsersDTO(UsersDTO HD)
        {
                _UserId = HD._UserId;
                _GroupId = HD._GroupId;
                _UserName = HD._UserName;
                _Password = HD._Password;
                _Email = HD._Email;
                _AddedDate = HD._AddedDate;
                _Actived = HD._Actived;
                _Locked = HD._Locked;
        }

        //Properties
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public int GroupId 
        {
            get { return _GroupId; }
            set { _GroupId = value; }
        }

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public DateTime AddedDate
        {
            get { return _AddedDate; }
            set { _AddedDate = value; }
        }

        public string Actived
        {
            get { return _Actived; }
            set { _Actived = value; }
        }

        public string Locked
        {
            get { return _Locked; }
            set { _Locked = value; }
        }
    }
}
