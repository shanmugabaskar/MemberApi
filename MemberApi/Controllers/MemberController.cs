using MemberData.Interface;
using MemberData.Model;
using MemberData.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MemberApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private IMembers members = new MembersRepository();

        [HttpGet]
        public IEnumerable<Members> GetAllMembers()
        {
            return members.GetAllMember();
        }

        [HttpGet("{id}")]
        public Members GetMemberById(int id)
        {
            return members.GetMember(id);
        }
    }
}
