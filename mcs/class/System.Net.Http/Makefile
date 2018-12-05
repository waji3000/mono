thisdir = class/System.Net.Http

include ../../build/rules.make

LIBRARY = System.Net.Http.dll

LIB_REFS = System.Core System
KEYFILE = ../msfinal.pub
LIB_MCS_FLAGS = $(EXTRA_LIB_MCS_FLAGS) -unsafe -nowarn:436
ifeq (monodroid,$(PROFILE))
LIB_MCS_FLAGS += -d:XAMARIN_MODERN
endif

TEST_LIB_REFS = System System.Core
TEST_MCS_FLAGS =

LIBRARY_WARN_AS_ERROR = yes

EXTRA_DISTFILES = \
	TestData/testservereku.contoso.com.pfx

include ../../build/library.make

ifdef SOCKETSHTTPHANDLER
socketshandlertests = FunctionalTests UnitTests
else
socketshandlertests =
endif

SUBDIRS = $(socketshandlertests)

DIST_SUBDIRS = FunctionalTests UnitTests

xunit-test-local: xunit-test-recursive

run-xunit-test-local: run-xunit-test-recursive

check: check-recursive

