namespace CSharp8
{
    /// <summary>
    /// Компилятор может использовать модификатор readonly для оптимизации производительности.
    /// </summary>
    internal struct TestReadonlyMember
    {
        private int Number1 { get; set; }
        private int Number2 { get; set; }
        private readonly int Number3 { get; }

        public TestReadonlyMember(int number1, int number2)
        {
            Number1 = number1;
            Number2 = number2;
            Number3 = 3;
        }

        /// <remarks>
        /// Присвоить данные Number1 и Number2 в этом методе не получиться
        /// </remarks>
        public readonly string GetString()
        {
            //Number1 = 2;
            return $"{Number1} {Number2}";
        }

        /// <remarks>
        /// Здесь тоже
        /// </remarks>
        public readonly override string ToString()
        {
            //Number1 = 2;
            return $"{Number1} {Number2}";
        }

        /// <remarks>
        /// Здесь тоже
        /// </remarks>
        public int Sum
        {
            readonly get
            {
                //Number1 = 2;
                return Number1 + Number2;
            }
            set
            {

            }
        }
    }
}
