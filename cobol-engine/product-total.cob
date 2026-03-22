       IDENTIFICATION DIVISION.
       PROGRAM-ID. PRODUCT-TOTAL.

       DATA DIVISION.
       WORKING-STORAGE SECTION.
       01 ARG-COUNT     PIC 9(4).
       01 QTY           PIC 9(5).
       01 PRICE         PIC 9(9).
       01 TOTAL         PIC 9(12) VALUE 0.
       01 ARG-VALUE     PIC X(20).

       PROCEDURE DIVISION.
       MAIN-PARA.

           *> Get number of arguments
           ACCEPT ARG-COUNT FROM ARGUMENT-NUMBER

           *> First argument = number of products (ignore it)
           ACCEPT ARG-VALUE FROM ARGUMENT-VALUE

           PERFORM UNTIL ARG-COUNT <= 1

               *> Read quantity
               ACCEPT ARG-VALUE FROM ARGUMENT-VALUE
               MOVE FUNCTION NUMVAL(ARG-VALUE) TO QTY

               *> Read price (in cents)
               ACCEPT ARG-VALUE FROM ARGUMENT-VALUE
               MOVE FUNCTION NUMVAL(ARG-VALUE) TO PRICE

               *> Add to total
               COMPUTE TOTAL = TOTAL + (QTY * PRICE)

               SUBTRACT 2 FROM ARG-COUNT
           END-PERFORM

           DISPLAY TOTAL

           STOP RUN.