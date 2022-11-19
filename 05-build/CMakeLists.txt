cmake_minimum_required (VERSION 2.6)
project (YES)

set(MYDB_SOURCES btree_int.c 
conds.c 
config.c 
data.c 
db_engine.c 
db_main.c 
error.c 
index.c 
memory.c 
parser_commands.c 
parser_conds.c 
query.c 
result.c 
server_comm.c 
sql_parser.c 
strutil.c 
tabconf.c 
tabdef.c 
textfileio.c)
add_library(mydb STATIC ${MYDB_SOURCES} )

add_executable(testclient testclient.c client_comm.c)
target_link_libraries(testclient PUBLIC mydb -lreadline -lhistory)
add_executable(testserver testserver.c server_comm.c)
target_link_libraries(testserver PUBLIC mydb -lreadline -lhistory)
add_executable(testadmin testadmin.c)
target_link_libraries(testadmin PUBLIC mydb -lreadline -lhistory)