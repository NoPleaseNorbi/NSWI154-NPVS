OBJECTS = *.o
EXCEPTIONS = testserver.o testclient.o testadmin.o server_comm.o client_comm.o
EXCEPTIONS2 = testadmin.c testclient.c testserver.c server_comm.c client_comm.c
SOURCES = $(wildcard *.c)
TO_COMPILE = $(filter-out $(EXCEPTIONS2), $(SOURCES))
objects := $(TO_COMPILE:.c=.o)

all: clean $(objects) testclient testserver testadmin

.PHONY: all clean

$(objects): %.o: %.c
	$(CC) -c $(FLAGS) $^ -o $@

testclient: testclient.o client_comm.o libmydb.a
	$(CC) $(FLAGS) -o testclient -L. testclient.c client_comm.c -lmydb -lreadline -lhistory

testclient.o: testclient.c
	$(CC) $(FLAGS) -c testclient.c -o testclient.o

client_comm.o:
	$(CC) $(FLAGS) -c client_comm.c -o client_comm.o

testserver: testserver.o client_comm.o libmydb.a
	$(CC) $(FLAGS) -o testserver -L. testserver.c server_comm.c -lmydb -lreadline -lhistory

testserver.o: testserver.c
	$(CC) $(FLAGS) -c testserver.c -o testserver.o

server_comm.o:
	$(CC) $(FLAGS) -c server_comm.c -o server_comm.o

testadmin: testadmin.o libmydb.a
	$(CC) $(FLAGS) -o testadmin -L. testadmin.c -lmydb -lreadline -lhistory

testadmin.o: testadmin.c
	$(CC) $(FLAGS) -c testadmin.c -o testadmin.o

libmydb.a:
	ar -rovs libmydb.a $(filter-out $(EXCEPTIONS), $(wildcard *.o))

clean:
	rm -rf testadmin testclient testserver *.o libmydb.a
