namespace interface_practices{
    public class Gerbil : IGroundAnimal
    {
        public bool walking { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool eating { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool sleeping { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool beingCute {get; set;}
    }
}