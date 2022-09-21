\ Input: nums = [2,7,11,15], target = 9
\ Output: [0,1]
\ Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

: array ( n -- ) ( i -- addr )
    create cells allot
    does> swap cells + ;

: print-array ( addr n b -- )
    { addr len indexes }
    len 0 do
    indexes if
    I .
    endif
    addr I cells + ? cr
    loop ;

: inner ( addr n n n -- n b )
    { numsaddr len j n }
    false ( put default found boolean )
    len j 1+ do
        numsaddr I cells + @
        numsaddr j cells + @
        + n = if ( if sum eq target exit loop and put index )
            I unloop exit
        endif
    loop
    dup 0= invert if ( if found remove false )
        swap drop
    endif ;

: solve ( addr addr n n -- )
    { targetaddr numsaddr len n }
    len 1- 0 do
        numsaddr len I n inner
    dup if
        targetaddr 0 cells + ! ( put first index from inner )
        I targetaddr 1 cells + ! ( put second index )
    endif
    dup invert if
        drop
    endif
    loop ;





\ Create arrays
4 array nums
2 array target

\ Input
2 0 nums !
7 1 nums !
11 2 nums !
15 3 nums !

\ Print
0 nums 4 true print-array

\ Solve 9
0 target 0 nums 4 9 solve
." Solution for 9" cr
0 target 2 false print-array

\ Solve 17
0 target 0 nums 4 17 solve
." Solution for 17" cr
0 target 2 false print-array

\ Solve 22
0 target 0 nums 4 22 solve
." Solution for 22" cr
0 target 2 false print-array
