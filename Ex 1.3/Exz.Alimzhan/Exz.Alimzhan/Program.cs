using Exz.Alimzhan.Data;
using Exz.Alimzhan.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Timers;
using Timer = System.Timers.Timer;
using Exz.Alimzhan.Service;

namespace Exz.Alimzhan
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.StartMenu();
        }
    }
}
       

       