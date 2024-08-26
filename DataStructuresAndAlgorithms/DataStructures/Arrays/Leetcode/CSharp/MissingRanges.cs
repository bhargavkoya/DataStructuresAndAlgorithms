//vector<string> findMissingRanges(vector<int> &nums, int lo, int up) {
//        // write your code here
//        vector<string> ans;
//        for(int i=0;i<nums.size();i++)
//        {
//               if(lo<nums[i])
//               {
//                      if(nums[i]-lo==1)
//                      ans.push_back(to_string(lo));
//                      else{
//                            ans.push_back( to_string(lo)+ "->" + to_string(nums[i]-1));

//                      }
                     
//               }
//               if(nums[i]==INT_MAX)
//               return ans;
//              lo= nums[i]+1;
//        }
//          if(lo==up)
//               ans.push_back( to_string(lo));
//               else if(lo<up)
//               ans.push_back( to_string(lo) +"->" + to_string(up));
//        return ans;
//    }