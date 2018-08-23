#!/bin/bash
#Create Randon
uRandom=$RANDOM
#Notify User
echo "Assinging Random"
#Variable to keep loop running
userWon=1
#Loop
while [ $userWon == 1 ]
do
#Ask user and assign input to variable
read -p "Enter an integer between 0-32767: " userInput
#Assign useranswer to input
useranswer=$userInput
#Error handling for letters
if [[ $userInput -eq  A-Za-z ]]
then
#Message
echo -e "Not a valid number"
else
#Unused Variable
uanswer=6
#Check if userInput equals to random
if [ $useranswer -eq $uRandom ]
then
#User message displayed
echo  " Congratulations you passed "
#End game by setting userWon to 0, closes while loop
userWon=0
#Check if userInput exceeds  random
elif [ $useranswer -gt $uRandom ]
then
#User message displayed
echo " Your answer was too high "
#Check if userInput is lower than  random
elif [ $useranswer -lt $uRandom ]
then
#User message displayed
 echo  " Your answer was too low "
 fi
fi
#Closes selection
done
