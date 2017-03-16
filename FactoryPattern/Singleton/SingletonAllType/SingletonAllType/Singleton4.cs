using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonAllType
{
    public sealed class Singleton4
    {
        static readonly Singleton4 instance = new Singleton4();

        //Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        
        static Singleton4()
        {

        }

        //Thêm default private constructor ở dưới --> nó sẽ đè lên static constructor ở trên
        //Lúc này mới đảm bảo được là Singleton4 không được phép tạo thể hiện thông qua từ khóa new
        private Singleton4()
        {

        }

        public static Singleton4 Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
