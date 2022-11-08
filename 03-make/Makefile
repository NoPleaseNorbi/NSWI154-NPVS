CC := gcc
CFLAGS := -g -Wall

SRC := src

NESTED_CALL = cd $(SRC) && $(MAKE) CC="$(CC)" CFLAGS="$(CFLAGS)"

.PHONY: all clean testclient testserver testadmin

all:
	cd $(SRC) && $(MAKE) all
