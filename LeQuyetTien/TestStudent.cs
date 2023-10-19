using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeQuyetTien
{
    internal class TestStudent
    {
        public void Create(ref int n, ref Student[]st )
        {           
            for(int i = 0; i < n; i++)
            {              
                st[i]=new Student();
                Console.WriteLine("Nhap vao thong tin cua hoc sinh: ");
                Console.Write("Id: ");
                st[i].Id = Console.ReadLine();
                Console.Write("Name: ");
                st[i].Name = Console.ReadLine();
                Console.Write("Gender: ");
                st[i].Gender = Console.ReadLine();
                Console.Write("Age: ");
                st[i].Age = int.Parse(Console.ReadLine());
                Console.Write("Date of birth: ");
                st[i].Dateofbirth = Console.ReadLine();
                Console.Write("Class: ");
                st[i].Class = Console.ReadLine();
                Console.Write("Mark 1: ");
                st[i].Mark1 = double.Parse(Console.ReadLine());
                Console.Write("Mark 2: ");
                st[i].Mark2 = double.Parse(Console.ReadLine());
                Console.Write("Mark 3: ");
                st[i].Mark3 = double.Parse(Console.ReadLine());
            }
        }
        public void Search(ref int n, ref Student[] st)
        {
            Console.WriteLine("Nhap ten cua hoc sinh ban muon tim: ");
            string name= Console.ReadLine();
            bool a= false;
            
            for(int i = 0; i < n; i++)
            {
                if (String.Compare(st[i].Name, name) == 0)
                {
                    Console.WriteLine("Thong tin cua hoc sinh thu: "+i+1);
                    Console.WriteLine("Name: " + st[i].Name);
                    Console.WriteLine("Gender: " + st[i].Gender);
                    Console.WriteLine("Age: " + st[i].Age);
                    Console.WriteLine("Date of birth: " + st[i].Dateofbirth);
                    Console.WriteLine("Class: " + st[i].Class);
                    Console.WriteLine("Mark 1: " + st[i].Mark1);
                    Console.WriteLine("Mark 2: " + st[i].Mark2);
                    Console.WriteLine("Mark 3: " + st[i].Mark3);
                    Console.WriteLine("Average mark: " + st[i].mark_AVG());
                    a= true;
                    break;
                }
            }
            if (a == false)
            {
                Console.WriteLine("Khong tim thay hoc sinh");
            }
        }
        public void Edit(ref int n, ref Student[] st)
        {
            Console.WriteLine("Nhap ID cua hoc sinh ban muon chinh sua: ");
            string id = Console.ReadLine();
            bool a = false;
            for (int i = 0; i < n; i++)
            {
                if (String.Compare(st[i].Id, id) == 0)
                {
                    Console.WriteLine("Ban muon sua thong tin nao?");
                    string info = Console.ReadLine();
                    switch (info)
                    {
                        case "Name":
                            st[i].Name = Console.ReadLine();
                            break;
                        case "Gender":
                            st[i].Gender = Console.ReadLine();
                            break;
                        case "Age":
                            st[i].Age = int.Parse(Console.ReadLine());
                            break;
                        case "Date of birth":
                            st[i].Dateofbirth = Console.ReadLine();
                            break;
                        case "Class":
                            st[i].Class = Console.ReadLine();
                            break;
                        case "Mark 1":
                            st[i].Mark1 = double.Parse(Console.ReadLine());
                            break;
                        case "Mark 2":
                            st[i].Mark2 = double.Parse(Console.ReadLine());
                            break;
                        case "Mark 3":
                            st[i].Mark3 = double.Parse(Console.ReadLine());
                            break;
                    }
                    a= true;
                    break;
                }
            }
            if (a == false)
            {
                Console.WriteLine("Khong tim thay hoc sinh can chinh sua");
            }
        }
        public void Delete(ref int n, ref Student[] st)
        {
            Console.WriteLine("Nhap id cua hoc sinh muon xoa: ");
            string id= Console.ReadLine();
            bool a= false;
            for(int i = 0; i < n-1; i++)
            {
                if (String.Compare(st[i].Id, id) == 0)
                {
                    for (int j = i; j < n-1; j++)
                    {
                        st[j] = st[j + 1];
                    }
                    n--;
                    break;
                }                           
            }           
        }
        public void Sort(ref int n, ref Student[] st)
        {
            /*Student temp = st[0];*/
            for(int i = 0; i < n; i++)
            {
                for(int j = i+1; j < n; j++)
                {
                    if (st[i].mark_AVG() >= st[j].mark_AVG())
                    {
                        Student temp = st[i];
                        st[i] = st[j];
                        st[j]= temp;
                    }
                }             
            }
            Console.WriteLine("Danh sach hoc sinh sau khi sap xep diem la: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Name: " + st[i].Name+", diem tb: " + st[i].mark_AVG());             
            }
        }
        public void Display(ref int n, ref Student[] st)
        {
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Thong tin hoc sinh thu " + i+1);
                Console.WriteLine("Id: " + st[i].Id);
                Console.WriteLine("Name: " + st[i].Name);
                Console.WriteLine("Gender: " + st[i].Gender);
                Console.WriteLine("Age: " + st[i].Age);
                Console.WriteLine("Date of birth: " + st[i].Dateofbirth);
                Console.WriteLine("Class: " + st[i].Class);
                Console.WriteLine("Mark 1: " + st[i].Mark1);
                Console.WriteLine("Mark 2: " + st[i].Mark2);
                Console.WriteLine("Mark 3: " + st[i].Mark3);
                Console.WriteLine("Average mark: " + st[i].mark_AVG());
            }
        }
    }
}
