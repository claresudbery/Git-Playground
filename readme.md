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
	
To see parents of a merge:
	Find the merge commit, get its ID (hit gitk on command line and copy "SHA1 ID" for the relevant commit)
	git show [commit id]
	Parents are numbered 1 and 2. The first one shown is number 1.	
	
To reset back to before the merge:
	Find the commit immediately before the merge, get its ID (hit gitk on command line and copy "SHA1 ID" for the relevant commit)
	git reset [commit id]
	
Setting up Git Command shortcuts (git aliases):
	This: git config --global alias.cm 'commit -m'
		This will set up an alias so that instead of typing git commit –m, you can now just type git cm
	This: git config –list
		This will show you what aliases you already have set up
	If you add something or create duplicates by accident, you can directly edit the config file:
		This: git config --global –edit
		This will put you in a VIM editor – see VIM instructions elsewhere in this doc
