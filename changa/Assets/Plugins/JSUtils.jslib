mergeInto(LibraryManager.library,
{
    OpenTab : function(url)
    {
        url = Pointer_stringify(url);
        window.open(url,'_blank');
    },

    openAd: function() // Called by unity from Create Ad Button
	{
		// call function in index
		 adBreak({
        type: 'next',  // ad shows at start of next level
        name: 'restart-game',
        // beforeAd: () => { this.disableButtons(); },  // You may also want to mute the game's sound.
        // afterAd: () => { this.enableButtons(); },    // resume the game flow.
      });
		
	},
});
