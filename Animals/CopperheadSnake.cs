namespace interface_practices
{
    public class CopperheadSnake : IGroundAnimal
    {
        public bool walking { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool eating { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool sleeping { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool striking {get; set;}
    }
}