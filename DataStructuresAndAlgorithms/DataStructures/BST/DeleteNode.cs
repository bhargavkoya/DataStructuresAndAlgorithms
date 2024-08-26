Node Delete(Node root, int data) 

{ 

 if(root==null) return root; 

 else if(data<root.data) 

  { 

    root.left=Delete(root.left,data); 

  } 

 else if(data>root.data) 

  { 

    root.right=Delete(root.right,data); 

  } 

Else 

{ 

//leaf node 

  if(root.left==NULL && root.right==NULL) 

  { 

      root==NULL; 

         return root; 

  } 

  else if(root.left==NULL) 

   { 

     root=root.right;  

    return root; 

    } 

  else if(root.right==NULL) 

   { 

     root=root.left; 

     return root; 

    } 

Else 

  { 

    Node temp=FindMin(root.right); 

    root.data=temp.data; 

    root.right=Delete(root.right,temp.data); 

    return root; 

  } 

} 

} 

Node FindMin(Node root) 

{ 

 if(root==null) 

   return root; 

 if(root.left==NULL) 

    return root; 

 

 return FindMin(root.left); 

} 