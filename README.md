# Lakiaro

BDO Lakiaro Caculator Project 

Calculating based on PEN:Hoe

얕게파기(Dig Shallowly)(s-dig) 28
깊게파기(Dig Deeply)(d-dig) 250

Grid: 12 X 12
Center 4 * 4



# Buttons
1. Reset
2. Calculate
3. Undo

## Clear
1. Remove all the dirt 
2. Save the Root as many as possible.

## Base Root Condition

1. Minimum 6 
2. Maximum 9
3. Decreasing at 5
4. Starting point are 16 points; edges of the center
5. 

It's like Maze
Using NSWE

Recommendation cell as red outline
Click the cell and 

##  Types of tile

1. Rock
2. Dirt
3. Root(BASE)
4. Root(DESC)
5. Root(END)
6. Root With two direction(Using same tile with rotation) 
    1. N->S
    2. N->E
    3. N->W

    1. S->N
    2. S->E
    3. S->W

    1. E->W
    2. E->N
    3. E->S

    1. W->E
    2. W->N
    3. W->S


## Startegy 1 Steps

1. First 4 Corners (4 s-dig) Left: 28
    1. Root
        1. Check the type
        2. store the possible root data
    2. Dirt
        1. Check the possible root and rock cells
    3. Rock
2. 8 Cells  (8 s-dig) Left: 16
    1. Root
        1. Check the type
    2. Dirt
        1. If all edges are dirts
        2. check that Corner can be d-dig
    3. Rock
        1. Unluck
3. Find 5th root(DESC)
    1. Check Possible starting and 8th root
4. Find 8th root
    1. 



## Wild Root Condition
1. Minimum 7
2. Maximum 13
3. Decreasing at 7



### Problems
1. Get Location of Button inside the panel to show other panel
2. make transparent panel background
3. 