namespace Core
{
    public class HelloWorld
    {
        private int _I = 0;
        private string _S = null;
        private string _M = null;

        public HelloWorld()
        {
            I = 123;
            S = "ABC";
            M = "HelloWorld()";
        }

        public HelloWorld(int i, string s)
        {
            I = i;
            S = s;
            M = "HelloWorld(int i, string s)";
        }

        public int I
        {
            get { return _I; }
            set { _I = value; }
        }

        public string S
        {
            get { return _S; }
            set { _S = value; }
        }

        public string M
        {
            get { return _M; }
            set { _M = value; }
        }
    }
}
