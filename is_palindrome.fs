: nrshift ( n -- n )
    10 / ;

: nlshift ( n -- n )
    10 * ;

: rem ( n -- n )
    10 mod ;

: is_palindrome ( n -- b )
    { n }
    0 \ reverse number
    n
    begin dup 0= invert while
        dup rem \ get remainder
        rot + nlshift \ add and shift reverse number
        swap nrshift \ shift N
    repeat
    drop \ drop zero
    nrshift \ shift reverse
    n = ;

: print_bool ( b -- )
    dup if ." true" endif
    dup invert if ." false" endif
    drop ;

." 1234321 is palindrome: " 1234321 is_palindrome print_bool cr
." 123321 is palindrome: " 123321 is_palindrome print_bool cr
." 123 is palindrome: " 123 is_palindrome print_bool cr
." 1222 is palindrome: " 1222 is_palindrome print_bool cr
