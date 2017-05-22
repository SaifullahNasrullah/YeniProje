/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dfs;

/**
 *
 * @author saifullah
 */
public class DFS {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Graph theGraph= new Graph();
        theGraph.addVertex('A');    // 0
        theGraph.addVertex('B');    // 1 
        theGraph.addVertex('C');    // 2 
        theGraph.addVertex('D');    // 3 
        theGraph.addVertex('E');    // 4
        theGraph.addEdge(0, 1);     // AB 
        theGraph.addEdge(1, 2);     // BC 
        theGraph.addEdge(0, 3);     // AD 
        theGraph.addEdge(3, 4);     // DE
        System.out.print("Visits");
        theGraph.dfs();             // depth-first search 
        System.out.println(); 
    }
    class StackX { 
        private final int SIZE = 20;
        private int[] st; 
        private int top;
        public StackX(){
          st = new int[SIZE];    
          top = -1; 
        } 
        public void push(int j){
            st[++top]=j;
        }
        public int pop(){
            return st[top--];
        }
        public int peek(){
            return st[top];
        }
        public boolean isEmpty(){
            return (top==-1);
        }
    }
    class Vertex{
        public char label;
        public boolean wasVisited;
        public Vertex(char lab){
            label=lab;
            wasVisited=false;
        }
    }
    class Graph{
        public final int MAX_VERTS = 20; 
        public Vertex vertexList[];
        public int adjMat[][];    
        public int nVerts;       
        public StackX theStack;
        
        public Graph(){
            vertexList = new Vertex[MAX_VERTS]; // adjacency matrix 
           adjMat = new int[MAX_VERTS][MAX_VERTS]; 
           nVerts = 0; 
           for(int j=0; j<MAX_VERTS; j++)      // set adjacency 
              for(int k=0; k<MAX_VERTS; k++)   //    matrix to 0 
                  adjMat[j][k] = 0; theStack = new StackX(); 
        }  
        public void addVertex(char lab){ 
            vertexList[nVerts++] = new Vertex(lab); 
        } 
        public void addEdge(int start, int end) { 
            adjMat[start][end] = 1; 
            adjMat[end][start] = 1; 
        }
        public void displayVertex(int v) { 
            System.out.print(vertexList[v].label); 
        } 
        
        public void dfs(){                                 
            vertexList[0].wasVisited = true;
            displayVertex(0);             
            theStack.push(0);                
            while( !theStack.isEmpty() )     { 
                int v = getAdjUnvisitedVertex( theStack.peek() );
                if(v == -1)                    
                    theStack.pop(); 
                else
                { 
                    vertexList[v].wasVisited = true;  
                    displayVertex(v);
                    theStack.push(v);
                }
            }
             for(int j=0; j<nVerts; j++){          
                 vertexList[j].wasVisited = false; 
           }  
        }
        public int getAdjUnvisitedVertex(int v) { 
            for(int j=0; j<nVerts; j++) 
                if(adjMat[v][j]==1 && vertexList[j].wasVisited==false) 
                    return j; return -1; 
        } 
    }
}
