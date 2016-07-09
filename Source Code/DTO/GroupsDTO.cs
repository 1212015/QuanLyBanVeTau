using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    class GroupsDTO
    {
        private int _groupId;
        private string _groupName;

        //Phương thức khởi tạo mặc định
        public GroupsDTO()
        {
            _groupId = 0;
            _groupName = "";

        }

        //Phương thức khởi tạo có tham số
        public GroupsDTO(int groupId, string groupName)
        {
            _groupId = groupId;
            _groupName = groupName;
        }

        //Phương thức khởi tạo sao chép.
        public GroupsDTO(GroupsDTO HoaDon)
        {
            _groupId = HoaDon._groupId;
            _groupName = HoaDon._groupName;
        }

        //Properties
        public int GroupId
        {
            get { return _groupId; }
            set { _groupId = value; }
        }
        public string GroupName
        {
            get { return _groupName; }
            set { _groupName = value; }
        }
    }
}
