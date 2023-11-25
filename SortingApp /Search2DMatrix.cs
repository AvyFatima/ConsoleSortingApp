using System;
using System.Collections.Generic;
using System.Linq;

class SearchTwoDMatrix {
  static void Main() {
     
    //Write any 2 D Matrix Sample here
     int[,] mat = new int[3,3];
      
     mat[0,0] = 1;
     mat[0,1] = 2;
     mat[0,2] = 3;
     
     mat[1,0] = 4;
     mat[1,1] = 8;
     mat[1,2] = 13;
     
     mat[2,0] = 10;
     mat[2,1] = 12;
     mat[2,2] = 14;

    //Search for int target in the Matrix 
      int target = 11;
    
     Console.WriteLine("Answer: " + findTarget(mat, target));
    
  }
  static bool findTarget(int[,] mat, int target){
     
     if(mat.GetLength(1)>0){
         
         int row = 0;
         int col = 0;
         
         while(col>=0 && row<mat.GetLength(0)){
             
             if(mat[row,col] == target){
                return true;
             }else if(mat[row,col] < target){
                 col++;
                 if(col > mat.GetLength(1)-1){
                     if(row < mat.GetLength(0)){
                        col = 0; 
                        row++;
                     }else{
                         return false;
                     }
                 }
             }else{
                 col = 0;  row++;
             }
         }
     }
     
     return false;
  }
}
