\ STM8EF dictionary management
\ refer to github.com/TG9541/stm8ef/blob/master/LICENSE.md

\ Set RESET defaults to include newly defined NVM words
: PERSIST ( -- )
  NVM
  'BOOT DUP $12 DUP ROT + SWAP CMOVE
  RAM
;
