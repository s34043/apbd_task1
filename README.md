This commit was created directly on main branch. 
1
Git performs a fast-forward when the target branch has no new commits and can simply move forward to the latest commit of the merged branch.

2
Merge keeps the full branch history and usually creates a merge commit.  
Rebase rewrites commits on top of another branch, which makes the history cleaner and more linear.

3
The conflict was resolved manually in `Program.cs` by editing the conflicting lines, removing the conflict markers, and keeping the final combined version of the code.
