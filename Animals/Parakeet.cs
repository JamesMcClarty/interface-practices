namespace interface_practices{

    public class Parakeet : IFlyingAnimal
    {
        public bool flying { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool eating { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool sleeping { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool tweeting {get; set;}
    }
}