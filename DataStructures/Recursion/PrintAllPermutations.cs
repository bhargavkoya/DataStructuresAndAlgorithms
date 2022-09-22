public class Solution{
    //With additional space
    public void recurPermute1(int[] arr,List<int> ds,List<IList<int>> res,bool[] freq){
        if(ds.Count==arr.Length){
            res.Add(new List<int>(ds));
            return;
        }
        for(int i=0;i<arr.Length;i++){
            if(!freq[i]){
                ds.Add(arr[i]);
                freq[i]=true;
                recurPermute(arr,ds,res,freq);
                ds.RemoveAt(ds.Count-1);
                freq[i]=false;
            }
        }
    }

    //without additional space
    public void recurPermute2(int ind,int[] arr,List<IList<int>> res){
        if(ind==arr.Length){
            List<int> ds=new List<int>();
            for(int k=0;k<arr.Length;k++)
                ds.Add(arr[k]);
            res.Add(new List<int>(ds));
            return;
        }
        for(int i=ind;i<arr.Length;i++){
           swap(i,ind,arr);
           recurPermute2(ind+1,arr,res);
           swap(i,ind,arr);
        }
    }
    public void swap(int i,int j,int[] arr){
        int temp=arr[j];
        arr[j]=arr[i];
        arr[i=temp;]
    }

    public List<List<int>> permutations(int[] arr){
        List<IList<int>> res=new List<IList<int>>();
        bool[] freq=new bool[arr.Length];
        recurPermute2(0,arr,res);
        return res;
    }
}