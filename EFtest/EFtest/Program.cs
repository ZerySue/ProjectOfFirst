using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFtest
{
    class Program
    {
        static void Main(string[] args)
        {//创建数据库访问网关
            using (SchoolDBEntities1 schoolEntities = new SchoolDBEntities1())
            {
                //查询到老师对应的班级的外键，注意是使用的linq to ef ,它是生成的命令树，然后是生成的sql

                var cls = (from c in schoolEntities.T_Class
                           where c.ID == 2
                           select c).SingleOrDefault<T_Class>();
                //创建teacher一个实体
                T_Teacher teacher = new T_Teacher();
                teacher.Address = "北京海淀上地";
                teacher.Email = "malun666@126.com";
                teacher.T_Class = cls;

                teacher.Name = "Flydragon";
                teacher.Phone = "110";
                //将创建的实体，放入网关的数据实体的集合
                schoolEntities.T_Teacher.Add(teacher);
                //写回数据库
                schoolEntities.SaveChanges();
            }
            Console.WriteLine("OK");
        }
    }
}
