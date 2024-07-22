
namespace Leetcode.Array
{
    public class GroupAnagrams
    {
        public static IList<IList<string>> GroupAnagramsSolution(string[] strs)
        {
            var dict = new Dictionary<string, IList<string>>();
            foreach (string str in strs)
            {
                string strKey = String.Concat(str.OrderBy(s => s));
                if(!dict.ContainsKey(strKey))
                {
                    dict[strKey] = new List<string>();
                } 
                
                dict[strKey].Add(str);               
            }

            return dict.Values.ToList();
        }
    }
}
