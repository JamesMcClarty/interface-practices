namespace interface_practices{

    public class Terrapin : ISwimmingAnimal
    {
        public bool swiming { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool eating { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool sleeping { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool hidingInShell {get; set;}
    }
}