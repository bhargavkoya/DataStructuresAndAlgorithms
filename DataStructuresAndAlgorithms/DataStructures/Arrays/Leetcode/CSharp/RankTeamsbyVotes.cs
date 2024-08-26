 public class ComararerCustom:IComparer<char>{
        RankTeamByVotes s=new RankTeamByVotes();
            public int compare(char a ,char b,int index){
                if(index==26)
                    return Convert.ToInt32(a<b);
                if(s.freq[a-'A',index]>s.freq[b-'A',index])
                    return Convert.ToInt32(true);
                if(s.freq[a-'A',index]<s.freq[b-'A',index])
                    return Convert.ToInt32(false);
                return compare(a,b,index+1);
            }

            public int Compare(char ch1,char ch2){
                return compare(ch1,ch2,0);
            }
}
   
public class RankTeamByVotes {
   public int[,] freq=new int[26,26];
    ComararerCustom comp =new ComararerCustom();
    public string RankTeams(string[] votes) {
        for(int i=0;i<26;i++){
            for(int j=0;j<26;j++){
                freq[i,j]=0;
            }
        }
        
        for(int k=0;k<votes.Length;k++){
            string temp=votes[k];
            for(int i=0;i<votes[k].Length;i++){
                freq[temp[i]-'A',i]++;
            }
        }
        string res=votes[0];
        //Array.Sort(res,comp); ==> need to uncomment it
        return res;
        
        
    }
}