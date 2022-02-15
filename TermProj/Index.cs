namespace TermProj
{
    public class Index
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int MinDistance { get; set; }

        public Index(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"{X},{Y}";
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Index);
        }

        public bool Equals(Index i)
        {
            if(i == null)
            {
                return false;
            }

            return this.X.Equals(i.X) && this.Y.Equals(i.Y);
        }

    }
}
