using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class AverageOfLevelsInBinaryTree
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            // Initialize a list to store the average values of each level
            var result = new List<double>();

            // If the root is null, return the empty result list
            if (root == null)
            {
                return result;
            }

            // Initialize a queue for BFS traversal and enqueue the root node
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            // Continue the BFS traversal until the queue is empty
            while (queue.Count > 0)
            {
                // Get the number of nodes at the current level
                int levelCount = queue.Count;

                // Initialize the sum of value's at the current level
                double levelSum = 0;

                // Process each node at the current level
                for (int i = 0; i < levelCount; i++)
                {
                    // Dequeue a node from the queue
                    var node = queue.Dequeue();

                    // Add the node's value to the level sum
                    levelSum += node.val;

                    // Enqueue the left child if it exists
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    // Enqueue the right child if it exists
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
                // Calculate the average for the current level and add it to the result list
                result.Add(levelSum / levelCount);
            }
            // Return the list of average values for each level
            return result;
        }
    }
}
