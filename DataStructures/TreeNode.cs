namespace DataStructures
{
    public class TreeNode
    {
        public int Key {  get; set; }
        public string Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public TreeNode(int key, string value) 
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
