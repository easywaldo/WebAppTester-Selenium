using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppTester
{
    class Program
    {
        static void Main(string[] args)
        {
            NaverUITester naverUITester = new NaverUITester();
            naverUITester.naver_login_is_correctly();
        }
    }
}
