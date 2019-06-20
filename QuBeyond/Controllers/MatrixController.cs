using Microsoft.AspNetCore.Mvc;
using QuBeyond.Backend.IServices;
using QuBeyond.Backend.Services;
using QuBeyond.Model;
using System.Collections.Generic;
using System.Linq;

namespace QuBeyond.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatrixController : ControllerBase
    {

        [HttpPost]
        public ActionResult<IEnumerable<string>> GetMatrixQu(QuMatrixModel model)
        {
            if (!model.Valid())
            {
                return BadRequest();
            }
            IWordFinder myMatrix = new WordFinder(model.matrix);

            return myMatrix.Find(model.words).ToArray();
        }
    }
}
