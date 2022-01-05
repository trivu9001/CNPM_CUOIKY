def max(A,B):
    if A>B:
        return A
    return B

def CoinRow(C):
    F=[0 for _ in range(len(C)+1)]
    F[0]=0
    F[1]=C[1]
    for i in range(2,len(C)):
        F[i]= max(C[i]+F[i-2],F[i-1])
    return F[len(C)-1]

C=[0,1,6,3,4,5]

print(CoinRow(C))
#this is Tan
### Update 2
#this is tri(update 3)
