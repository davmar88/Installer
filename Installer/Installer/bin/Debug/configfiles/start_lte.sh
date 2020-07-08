#!/bin/sh
# This is a comment!
echo starting lte        # This is a comment, too!

cd ~
cd githubdownloads/openairinterface5g/cmake_targets/ran_build/build
sudo sh -c "exec dos2unix -k -o lte-softmodem"
sudo sh -c "exec ./lte-softmodem -O ../enb.conf"


