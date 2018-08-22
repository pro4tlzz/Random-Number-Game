#!/bin/bash
userWon=1
while [ $userWon == 1 ]
do
read -p "Enter an integer between 1-10: " userInput

useranswer=$userInput
if [[ $userInput -eq  A-Za-z ]]
then
echo -e "Not a valid number"
else
uanswer=6
if [ $useranswer -eq $uanswer ]
then
echo  " Congratulations you passed "
userWon=0
elif [ $useranswer -gt $uanswer ]
then
echo " Your answer was too high "
elif [ $useranswer -lt $uanswer ]
then
 echo  " Your answer was too low "
 fi
fi
done
