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


