using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principle
{    
    // we can small interface for differnent related operation so we dont want to foce implement all method to class
    // we can implement interface as per requirement
    public  interface IAddOperation
    {
        bool AddEmployeeDEtails();
    }
}
