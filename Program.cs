using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241219_OOP001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //========================================
            //單一物件型態的宣告, 宣告時即會配Memory.
            //=======================================
            Users LabUser = new Users();
            //宣告完即可操作物件:LabUser
            LabUser.Id = 1;
            
            //===========================================
            //陣列型態的物件宣告
            //====================================
            Users[] PcUsers = new Users[50];            
            //若用陣列型態宣告物件後,還要配一次記憶體空間
            for (int i = 0; i < PcUsers.Length; i++)
            {
                PcUsers[i] = new Users(i+1, "PcUsers" + (i + 1).ToString());
            }


            for (int i = 0; i < 50; i++) {
               //   // Create a new Users object
               // PcUsers[i]._Id = i + 1;
                //PcUsers[i].Name="PcUsers"+(i+1).ToString();
                Console.Write("ID is :"+ PcUsers[i].Id.ToString());
                Console.WriteLine(" Name is :"+ PcUsers[i].Name.ToString()); 
            }

        }
    }
}
