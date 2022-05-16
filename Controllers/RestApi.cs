using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rest2.Controllers
{

    [Route("sterrenbeelden")]
    [ApiController]
    public class Restservice : ControllerBase
    {
        //[HttpGet("{maand}/{dag}")]
        [HttpGet("{dagmaand}")]

        public ActionResult Findsterrenbeeldeng(string dagmaand)
        {
            int dag = Convert.ToInt32(dagmaand.Split('-')[0]);
            int maand = Convert.ToInt32(dagmaand.Split('-')[1]);

            if ((maand < 1 || maand > 12) || (dag < 1 || dag > 31))
            {

                return base.BadRequest("Foute Datum");
            }

            else
            {
                return base.Ok(GetSterrenbeeld(maand, dag));
            }


        }

        public static string GetSterrenbeeld(int maand, int dag)
        {
            switch (maand)
            {
               
                case 1:
                    if (dag <= 22)
                    { return "Steenbok"; }
                    else
                    { return "Waterman"; }
                case 2:
                    if (dag <= 19)
                    { return "Waterman"; }
                    else
                    { return "Acuario "; }
                case 3:
                    if (dag <= 20)
                    { return "Vissen"; }
                    else
                    { return "Ram"; }
                case 4:
                    if (dag <= 20)
                    { return "Ram"; }
                    else
                    { return "Estier"; }
                case 5:
                    if (dag <= 21)
                    { return "Estier "; }
                    else
                    { return "Tweelingen "; }
                case 6:
                    if (dag <= 22)
                    { return "Tweelingen"; }
                    else
                    { return "Kreeft "; }
                case 7:
                    if (dag <= 22)
                    { return "Kreeft "; }
                    else
                    { return "Lew"; }
                case 8:
                    if (dag <= 23)
                    { return "Lew"; }
                    else
                    { return "maagd"; }
                case 9:
                    if (dag <= 23)
                    { return "maag"; }
                    else
                    { return "Weegschaal"; }
                case 10:
                    if (dag <= 23)
                    { return "Weegschaal "; }
                    else
                    { return "Scorpio"; }
                case 11:
                    if (dag <= 22)
                    { return "Scorpio"; }
                    else
                    { return "Boogschutter "; }
                default:
                    if (dag <= 21)
                    { return "Boogschutter "; }
                    else
                    { return "Steenbok"; }

            }

        }

    }  
}


