/*

e^x=1+x+x^2/2+x^3/3+....
*/
int e(int x,int n){
    int p=1,f=1;
    if(n==0) return 1;
    else{
        int r=e(x,n-1);
        p=p*x;
        f=f*n;

        return r+p/f;
    }
}