using Microsoft.AspNetCore.Mvc;
using ThvLesson06Models.Models;

namespace ThvLesson06Models.Controllers
{
    public class ThvMemberController : Controller
    {
        //Mock data
        private static readonly List<ThvMember> _thvMembers = new List<ThvMember>()
        {
            new ThvMember()
            {
                ThvMemberId = Guid.NewGuid().ToString(),
                ThvMemberUserName = "VietTruongHoang",
                ThvMemberPassword = "Viet123",
                ThvMemberEmail = "viet@gmail.com",
                ThvMemberFullName = "Trương Hoàng Việt"
            },

            new ThvMember()
            {
                ThvMemberId = Guid.NewGuid().ToString(),
                ThvMemberUserName = "NguyenAn",
                ThvMemberPassword = "An123",
                ThvMemberEmail = "an@gmail.com",
                ThvMemberFullName = "Nguyễn Văn An"
            },

            new ThvMember()
            {
                ThvMemberId = Guid.NewGuid().ToString(),
                ThvMemberUserName = "TranMinh",
                ThvMemberPassword = "Minh123",
                ThvMemberEmail = "minh@gmail.com",
                ThvMemberFullName = "Trần Minh Đức"
            },

            new ThvMember()
            {
                ThvMemberId = Guid.NewGuid().ToString(),
                ThvMemberUserName = "LeHoa",
                ThvMemberPassword = "Hoa123",
                ThvMemberEmail = "hoa@gmail.com",
                ThvMemberFullName = "Lê Thị Hoa"
            },

            new ThvMember()
            {
                ThvMemberId = Guid.NewGuid().ToString(),
                ThvMemberUserName = "PhamNam",
                ThvMemberPassword = "Nam123",
                ThvMemberEmail = "nam@gmail.com",
                ThvMemberFullName = "Phạm Hoàng Nam"
            }
        };
        public IActionResult ThvIndex()
        {
            return View(_thvMembers);
        }
        /// <summary>
        /// Create
        /// </summary>
        /// <returns></returns>
        public IActionResult ThvCreate()
        {
            return View();
        }
        /// <summary>
        /// Create: submit form
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ThvCreate(ThvMember thvMember)
        {
            thvMember.ThvMemberId = Guid.NewGuid().ToString();
            _thvMembers.Add(thvMember);
            return RedirectToAction("ThvIndex");
        }
        /// <summary>
        /// ThvEdit
        /// </summary>
        /// <returns></returns>
        public IActionResult ThvEdit(string id)
        {
            var thvMember = _thvMembers.FirstOrDefault(x=>x.ThvMemberId.Equals(id));
            return View(thvMember);
        }
        /// <summary>
        /// Edit: submit form
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ThvEdit(string id, ThvMember thvMember)
        {
            for (int i = 0; i < _thvMembers.Count; i++)
            {
                if (_thvMembers[i].ThvMemberId == id)
                {
                    _thvMembers[i].ThvMemberId = thvMember.ThvMemberId;
                    _thvMembers[i].ThvMemberUserName = thvMember.ThvMemberUserName;
                    _thvMembers[i].ThvMemberPassword = thvMember.ThvMemberPassword;
                    _thvMembers[i].ThvMemberFullName = thvMember.ThvMemberFullName;
                    _thvMembers[i].ThvMemberEmail = thvMember.ThvMemberEmail;
                    break;
                }
            }
            return RedirectToAction("ThvIndex");
        }
        public IActionResult ThvGetDetails()
        {
            var thvMember = new ThvMember()
            {
                ThvMemberId = Guid.NewGuid().ToString(),
                ThvMemberUserName = "VietTruong",
                ThvMemberPassword = "Viet123",
                ThvMemberFullName = "Trương Hoàng Việt",
                ThvMemberEmail = "hoangvietbk2004@gmail.com"
            };
            return View(thvMember);
        }
    }
}
