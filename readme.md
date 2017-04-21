This repo is here to experiment with different git commands.

To create a new branch: 
	git checkout master
	git checkout -b a-new-branch
	
To merge: 
	git checkout master
	git merge another-branch
	
To abort a merge:
	git merge abort
	
To use kdiff3 as your merge tool:
	1) Add KDiff3 to your environment path (windows key | System Environment variables | Path)
	2) Either:
		2a)	Find your gitconfig file (probably in your P drive) and add the lines below:	
			[merge]
				tool = kdiff3
			[mergetool "kdiff3"]
				path = C:/Program Files/KDiff3/kdiff3.exe
				trustExitCode = false
			[diff]
				guitool = kdiff3
			[difftool "kdiff3"]
				path = C:/Program Files/KDiff3/kdiff3.exe
				trustExitCode = false
	or
		2b) Update gitconfig via the command line:
			git config --global --add merge.tool kdiff3
			git config --global --add mergetool.kdiff3.path "C:/Program Files/KDiff3/kdiff3.exe"
			git config --global --add mergetool.kdiff3.trustExitCode false
			git config --global --add diff.guitool kdiff3
			git config --global --add difftool.kdiff3.path "C:/Program Files/KDiff3/kdiff3.exe"
			git config --global --add difftool.kdiff3.trustExitCode false
	3) type git mergetool in gitbash

What to do if you get stuck in a Vim Editor:
	Type i to get into insert mode
		(if it’s worked, you’ll see “-- INSERT --” at bottom of screen
	Type your commit message
	Click Esc
	Type :wq
	Hit Enter

If you get stuck in the middle of a merge and want to abandon:
	(You may get a message like this: “You have not concluded your merge (MERGE_HEAD exists)”
	Use this: git merge abort
		If it says you need to commit changes first, you can just do git stash instead
		Or if you get “merge is not possible because you have unmerged files.”, you can do git add . and then git stash
	You can tell if it has worked in gitbash, because it will stop saying “MERGING” after the branch name

To revert the merge:
	Find the merge commit, get its ID (hit gitk on command line and copy "SHA1 ID" for the relevant commit)
	git revert [commit id] -m 1

To find the parents of a merge:
	Find the merge commit, get its ID (hit gitk on command line and copy "SHA1 ID" for the relevant commit)
	git show [commit id]
	Parents are numbered 1 and 2. The first one shown is number 1.

To reset back to before the merge:
	Find the commit immediately before the merge, get its ID (hit gitk on command line and copy "SHA1 ID" for the relevant commit)
	git reset [commit id]
	
Show remote branches:
	git branch -r
	
Git stash:
	git stash 
		will save all uncommitted changes in your working directory, ready to be recovered later
		!! Watch out - if you have added new files, you need to do git add . first.
	git stash save ‘stash name’
		Same as git stash (see below), but you can name the stash
		!! Watch out - if you have added new files, you need to do git add . first.
	git stash list
		will show you all your current stashes
		!! Type q to get back to command prompt
	git stash show stash@{2}
		will show details of a particular stash
	git stash apply
		will apply the most recent stash
	git stash apply stash@{2}
		will apply a specific stash
	git stash apply --index
		will reapply the stashed changes AND restage any files which were staged but not committed
	git stash pop
		will apply the most recent stash AND remove it from the stack (or a named stash - git stash pop stash@{2})
	git stash drop stash@{2}
		will remove the named stash from the stack
	git stash branch
		will create a new branch for you, check out the commit you were on when you stashed your work, reapply your work there, and then drop the stash if it applies successfully
	Stuff about applying stashes:
		If your working directory is not clean, it will attempt to merge changes, and let you know if any conflicts
		You don’t have to apply the stash to the branch it was originally saved on
	More here: http://git-scm.com/book/en/Git-Tools-Stashing 
	
Git aliases / command shortcuts:
	This: git config --global alias.cm 'commit -m'
		This will set up an alias so that instead of typing git commit –m, you can now just type git cm
	This: git config –list
		This will show you what aliases you already have set up
	If you add something or create duplicates by accident, you can directly edit the config file:
		This: git config --global –edit
		This will put you in a VIM editor – see VIM instructions elsewhere in this doc

git rm
	Removes a file from the repo
	Can also be used for removing a file from the repo but NOT from disk, like this
	(useful for when you have added files to gitignore after they’ve been committed)
	git rm --cached /path/to/file
