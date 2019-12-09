using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Data
{
    public class Hello
    {
        public Hello(GrpcService.HelloReply reply)
        {
            name = reply.Name;
            linkedin = reply.Linkedin;
            git = reply.Git;
        }
        public string name { get; set; }
        public string linkedin { get; set; }
        public string git { get; set; }
    }
}
