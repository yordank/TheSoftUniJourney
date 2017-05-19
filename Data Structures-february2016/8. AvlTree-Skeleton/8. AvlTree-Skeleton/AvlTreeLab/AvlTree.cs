namespace AvlTreeLab
{
    using System;
    
    public class AvlTree<T> where T : IComparable<T>
    {
        private Node<T> root;

        public int Count { get; private set; }
        
        public void Add(T item)
        {
            var inserted = true;
            if(this.root==null)
            {
                var newNode = new Node<T>(item);
                this.root = newNode;
                
            }

            else
            {
                inserted = this.InsertInternal(this.root, item);
            }

            if(inserted)
            {
                this.Count++;
            }

        }

        private bool InsertInternal(Node<T> node, T item)  
        {
            var currentNode = node;
            var newNode = new Node<T>(item);
            var ShouldRetrace = false;

            while(true)
            {
                if(currentNode.Value.CompareTo(item)<0)
                {
                    if(currentNode.RightChild==null)
                    {
                        //set newNode as right child
                        currentNode.RightChild = newNode;
                        newNode.Parent = currentNode;


                        currentNode.BalanceFactor--;
                        ShouldRetrace = currentNode.BalanceFactor != 0;
                        break;
                    }

                    currentNode = currentNode.RightChild;

                }

                else if (currentNode.Value.CompareTo(item) > 0)
                {
                    if(currentNode.LeftChild==null)
                    {
                        //set newNode as left child
                        currentNode.LeftChild = newNode;
                        newNode.Parent = currentNode;

                        currentNode.BalanceFactor++;
                        ShouldRetrace = currentNode.BalanceFactor != 0;
                        break;
                    }

                    currentNode = currentNode.LeftChild;
                }

                else
                {
                    Console.WriteLine("item already present->break");
                    return false;
                    
                }

            }

            if (ShouldRetrace)
            {
               this.RetraceInsert(currentNode);
            }

            return true;

        }

        private void RetraceInsert(Node<T> node)
        {
            var parent = node.Parent;

            while (parent!=null)
            {
                if(node.isLeftChild)
                {
                    if(parent.BalanceFactor==1)
                    {
                        parent.BalanceFactor++;

                        if(node.BalanceFactor==-1)
                        {
                            this.RotateLeft(node);
                        }

                        this.RotateRight(parent);
                        break;

                    }

                    else if(parent.BalanceFactor==-1)
                    {
                        parent.BalanceFactor = 0;
                        break;
                    }

                    else
                    {
                        parent.BalanceFactor = 1;
                    }

                }

                else 
                {
                    if(parent.BalanceFactor==-1)
                    {
                        parent.BalanceFactor--;
                        if(node.BalanceFactor==1)
                        {
                            this.RotateRight(node);
                        }

                        this.RotateLeft(parent);
                        break;

                    }
                    else if(parent.BalanceFactor==1)
                    {
                        parent.BalanceFactor = 0;
                        break;
                    }
                    else
                    {
                        parent.BalanceFactor = -1;
                    }
                }

                node = parent;

                parent = node.Parent;

            }

        }

        private void RotateRight(Node<T> node)
        {
            var parent = node.Parent;
            var child = node.LeftChild;

            if (parent != null)
            {
                if (node.isRightChild)
                    parent.RightChild = child;
                else
                    parent.LeftChild= child;
            }
            else
            {
                this.root = child;
                this.root.Parent = null;
            }


            node.LeftChild = child.RightChild;
            child.RightChild = node;

            node.BalanceFactor -= 1 + Math.Min(child.BalanceFactor, 0);
            child.BalanceFactor -= 1 - Math.Max(node.BalanceFactor, 0);


        }

        private void RotateLeft(Node<T> node)
        {
            var parent = node.Parent;
            var child = node.RightChild;

            if (parent != null)
            {
                if (node.isLeftChild)
                    parent.LeftChild = child;
                else
                    parent.RightChild = child;
            }
            else
            {
                this.root = child;
                this.root.Parent = null;
            }


            node.RightChild = child.LeftChild;
            child.LeftChild = node;

            node.BalanceFactor += 1 - Math.Min(child.BalanceFactor, 0);
            child.BalanceFactor += 1 + Math.Max(node.BalanceFactor, 0);


        }

        public bool Contains(T item)
        {
            var node = this.root;

            while(node!=null)
            {
                if(item.CompareTo(node.Value)>0)
                {
                    node = node.RightChild;
                }

                else if(item.CompareTo(node.Value)<0)
                {
                    node = node.LeftChild;
                }

                else if(item.CompareTo(node.Value)==0)
                {
                    return true;
                    
                }

            }

            return false;
        }

        public void ForeachDfs(Action<int, T> action)
        {
            if (this.Count == 0)
                return;

            this.InOrderDFS(this.root, 1, action);
        }

        private void InOrderDFS(Node<T> root, int depth, Action<int, T> action)
        {
            if (root.LeftChild != null)
            {
                InOrderDFS(root.LeftChild, depth + 1, action);
            }

                action(depth,root.Value);

            if (root.RightChild != null)
            {
                InOrderDFS(root.RightChild, depth + 1, action);
            }

        }
    }
}
