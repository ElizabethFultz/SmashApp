   M S B A M L   `   `   `  ����C  ?SmashApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:SmashAppSmashApp  5   	       SmashApp.UserProfile   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:SmashApp     5   	     � Title$  UserProfile��5   	   $	��900��6   $
��1400��6*   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��289* �6   �� 5      $	��59* �6   .+�5   
   �� -   5         ��Name$
 Logo��5      $
��Left=�6   $��41.123,713,-140,-37q�69   $	��Top=�6V   $��/Images/SmashApp1.png��6n   $	��193��6�   $	��335��6�   $��1��6�   �� 5   
   -   5         ��Name$ UserName_Label��5      $��
User Name:��6(   $
��Left=�6=   $��110,111,0,0q�6X   $	��Top=�6m   $��81��6�   $	��296��6�   $��48(�6�   $��MS Reference Sans Serif)�6�   �� 5   
   -   5        $ FavorietCharacter_Label��5      $��Favorite Character: ��61   $
��Left=�6P   $��110,197,0,0q�6k   $	��Top=�6�   $��81��6�   $	��495��6�   $��48(�6�   $��MS Reference Sans Serif)�6�   �� 5   
   -   5         ��Name$ Player1Character_ComboBox��5      $
��Left=�66   $��57��6Q   $��605,209,0,0q�6]   $	��Top=�6r   $	��304��6�    �� 
IsReadOnly . $��MS Reference Sans Serif)�6�   $��29(�6�   .@�5      �� $��Banjo & Kazooie��6   �� 5      $��	Bayonetta��6   �� 5      $��Bowser��6   �� 5      $��	Bowser Jr��6   �� 5      $��Byleth��6   �� 5      $��Captain Falcon��6   �� 5      $��Chrom��6   �� 5      $��Cloud��6   �� 5      $��Corrin��6   �� 5      $��Daisy��6   �� 5      $��Dark Pit��6   �� 5      $��
Dark Samus��6   �� 5      $��
Diddy Kong��6   �� 5      $��Donkey Kong��6   �� 5       $��Dr Mario��6   �� 5!      $��	Duck Hunt��6   �� 5"      $��Falco��6   �� 5#      $	��Fox��6   �� 5$      $��	Ganondorf��6   �� 5%      $��Greninja��6   �� 5&      $
��Hero��6   �� 5'      $��Ice Climbers��6   �� 5(      $	��Ike��6   �� 5)      $��
Incineroar��6   �� 5*      $��Inkling��6   �� 5+      $��Isabelle��6   �� 5,      $��
Jigglypuff��6   �� 5-      $��Joker��6   �� 5.      $��Kazuya��6   �� 5/      $	��Ken��6   �� 50      $��King Dedede��6   �� 51      $��King K. Rool��6   �� 52      $��Kirby��6   �� 53      $
��Link��6   �� 54      $��
Little Mac��6   �� 55      $��Lucario��6   �� 56      $��Lucas��6   �� 57      $��Lucina��6   �� 58      $��Luigi��6   �� 59      $��Mario��6   �� 5:      $��Marth��6   �� 5;      $��Mega Man��6   �� 5<      $��Meta Knight��6   �� 5=      $��Mewtwo��6   �� 5>      $��Mii Brawler��6   �� 5?      $��
Mii Gunner��6   �� 5@      $��Mii Swordfighter��6   �� 5A      $��Min Min��6   �� 5B      $��Mr. Game & Watch��6   �� 5C      $��Mythra��6   �� 5D      $
��Ness��6   �� 5E      $��Olimar��6   �� 5F      $��Pac-Man��6   �� 5G      $��Palutena��6   �� 5H      $��Peach��6   �� 5I      $��Pichu��6   �� 5J      $��Pikachu��6   �� 5K      $��Piranha Plant��6   �� 5L      $	��Pit��6   �� 5M      $��Pokemon Trainer��6   �� 5N      $
��Pyra��6   �� 5O      $��Richter��6   �� 5P      $��Ridley��6   �� 5Q      $��R.O.B.��6   �� 5R      $��Robin��6   �� 5S      $��Rosalina & Luma��6   �� 5T      $	��Roy��6   �� 5U      $	��Ryu��6   �� 5V      $��Samus��6   �� 5W      $��	Sephiroth��6   �� 5X      $��Sheik��6   �� 5Y      $��Shulk��6   �� 5Z      $��Simon��6   �� 5[      $��Snake��6   �� 5\      $��Sonic��6   �� 5]      $
��Sora��6   �� 5^      $��Steve��6   �� 5_      $��Terry��6   �� 5`      $��	Toon Link��6   �� 5a      $��Villager��6   �� 5b      $��Wario��6   �� 5c      $��Wii Fit Trainer��6   �� 5d      $
��Wolf��6   �� 5e      $��Yoshi��6   �� 5f      $��
Young Link��6   �� 5g      $��Zelda��6   �� 5h      $��Zero Suit Samus��6   �� 5i      $��Button��6   $��75��6&   5j      �� 5k   
   -   5        $ State_Label��5k      $��State:��6%   $
��Left=�66   $��110,278,0,0q�6Q   $	��Top=�6f   $��81��6~   $	��171��6�   $��48(�6�   $��MS Reference Sans Serif)�6�   �� 5l   
   -   5        $ City_Label_Copy��5l      $��City:��6)   $
��Left=�69   $��110,364,0,0q�6T   $	��Top=�6i   $��81��6�   $	��148��6�   $��48(�6�   $��MS Reference Sans Serif)�6�   �� 5m   
   -   5         ��Name$ StateTextBox��5m      $
��Left=�6(   $��76��6C   $��286,283,0,0q�6O    �� TextWrapping$
 Wrap=�6d   $��TextBox��6x   $	��Top=�6�   $	��380��6�   $��MS Reference Sans Serif)�6�   $��48(�6�   �� 5n   
   -   5        $ UserNameTextbox��5n      $
��Left=�6+   $��76��6F   $��411,111,0,0q�6R   $
 Wrap=�6g   $��TextBox��6{   $	��Top=�6�   $	��380��6�   $��48(�6�   $��MS Reference Sans Serif)�6�   �� 5o   
   -	   5        $ CityTextbox��5o      $
��Left=�6'   $��76��6B   $��263,369,0,0q�6N   $
 Wrap=�6c   $��TextBox��6w   $	��Top=�6�   $	��380��6�   $��MS Reference Sans Serif)�6�   $��48(�6�   �� 5p   
   -
   5         ��Name$ Home_Button��5p      $��	Main Menu��6&   $��Center=�6:   $��571,582,334.877,0q�6W   $	��Top=�6r   $��53��6�   $	��250��6�   $��MS Reference Sans Serif)�6�   $��36(�6�   ���	#FFE00B03
�������6�   �� 5q   
   -   5        $ 
SaveButton��5q      $��Save Player��6%   $��Center=�6;   $��110,477,795.877,0q�6X   $	��Top=�6s   $��53��6�   $	��250��6�   $��MS Reference Sans Serif)�6�   $��36(�6�   ���	#FFE00B03
�������6   5s      5t      