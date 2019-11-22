namespace interface_practices{
    public class Ant : IDiggingAnimal
    {
        public bool digging { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool eating { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool sleeping { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool carrying {get; set;}
    }
}