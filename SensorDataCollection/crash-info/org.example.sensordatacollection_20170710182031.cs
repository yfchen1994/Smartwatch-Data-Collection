S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 25525
Date: 2017-07-10 18:20:31+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x414d145c
r2   = 0x414d12b4, r3   = 0x00000001
r4   = 0x00000000, r5   = 0x414c1091
r6   = 0x414c0ee3, r7   = 0xbe8f8208
r8   = 0x4146f4f3, r9   = 0x000063b5
r10  = 0x4004e7e8, fp   = 0x00000000
ip   = 0x404d9b50, sp   = 0xbe8f7f20
lr   = 0x414c0ae9, pc   = 0x404d9b58
cpsr = 0x60000010

Memory Information
MemTotal:   491132 KB
MemFree:     10720 KB
Buffers:     20816 KB
Cached:     126540 KB
VmPeak:      73512 KB
VmSize:      73512 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15068 KB
VmRSS:       15068 KB
VmData:      13516 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23272 KB
VmPTE:          46 KB
VmSwap:          0 KB

Maps Information
40000000 40005000 r-xp /usr/bin/launchpad-loader
4000d000 4002a000 r-xp /lib/ld-2.13.so
40033000 40037000 r-xp /usr/lib/libsys-assert.so
40041000 40047000 r-xp /usr/lib/libappcore-efl.so.1.1
40056000 40063000 r-xp /usr/lib/libaul.so.0.1.0
4006d000 4006f000 r-xp /lib/libdl-2.13.so
40078000 4007b000 r-xp /usr/lib/libbundle.so.0.1.22
40083000 40085000 r-xp /usr/lib/libdlog.so.0.0.0
4008d000 400a1000 r-xp /lib/libpthread-2.13.so
400ac000 401e8000 r-xp /usr/lib/libelementary.so.1.7.99
401ff000 402cd000 r-xp /usr/lib/libevas.so.1.7.99
402f2000 40309000 r-xp /usr/lib/libecore.so.1.7.99
40320000 4037e000 r-xp /usr/lib/libedje.so.1.7.99
40388000 40458000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40459000 4045f000 r-xp /usr/lib/libprivilege-control.so.0.0.2
40467000 4046b000 r-xp /usr/lib/libsmack.so.1.0.0
40474000 4047c000 r-xp /lib/libgcc_s-4.6.so.1
4047d000 405a1000 r-xp /lib/libc-2.13.so
405af000 405cd000 r-xp /usr/lib/libsystemd.so.0.4.0
405d7000 405e2000 r-xp /lib/libunwind.so.8.0.1
4060f000 40626000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
4062e000 40658000 r-xp /usr/lib/libdbus-1.so.3.8.12
40661000 40666000 r-xp /usr/lib/libxdgmime.so.1.1.0
4066e000 40691000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
40699000 4069a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
406a2000 406a8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406b1000 4071a000 r-xp /lib/libm-2.13.so
40723000 4073c000 r-xp /usr/lib/libeet.so.1.7.99
4074d000 4078e000 r-xp /usr/lib/libeina.so.1.7.99
40797000 407b9000 r-xp /usr/lib/libecore_evas.so.1.7.99
407c2000 407c7000 r-xp /usr/lib/libecore_file.so.1.7.99
407cf000 407e0000 r-xp /usr/lib/libecore_input.so.1.7.99
407e8000 407f1000 r-xp /usr/lib/libvconf.so.0.2.45
407f9000 40849000 r-xp /usr/lib/libecore_x.so.1.7.99
4084b000 40854000 r-xp /usr/lib/libedbus.so.1.7.99
4085c000 40876000 r-xp /usr/lib/libecore_con.so.1.7.99
4087f000 40892000 r-xp /usr/lib/libfribidi.so.0.3.1
4089a000 408df000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
408e8000 40910000 r-xp /usr/lib/libfontconfig.so.1.8.0
40911000 40967000 r-xp /usr/lib/libfreetype.so.6.11.3
40973000 409c9000 r-xp /usr/lib/libpixman-1.so.0.28.2
409d6000 409dc000 r-xp /lib/librt-2.13.so
409e5000 409ec000 r-xp /usr/lib/libembryo.so.1.7.99
409f4000 40a0b000 r-xp /usr/lib/liblua-5.1.so
40a14000 40a1a000 r-xp /usr/lib/libecore_imf.so.1.7.99
40a22000 40a23000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40a2b000 40a5a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40a62000 40a65000 r-xp /lib/libcap.so.2.21
40a6d000 40a85000 r-xp /usr/lib/liblzma.so.5.0.3
40a8d000 40a9d000 r-xp /lib/libresolv-2.13.so
40aa1000 40b74000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40b7f000 40bb3000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40bbc000 40bd6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40bde000 40c53000 r-xp /usr/lib/libsqlite3.so.0.8.6
40c5d000 40c5f000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
40c67000 40c7d000 r-xp /lib/libz.so.1.2.5
40c85000 40ca8000 r-xp /usr/lib/libjpeg.so.8.0.2
40cc0000 40da1000 r-xp /usr/lib/libX11.so.6.3.0
40dac000 40db1000 r-xp /usr/lib/libecore_fb.so.1.7.99
40dba000 40dbe000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40dc7000 40dca000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40dd2000 40dd9000 r-xp /usr/lib/libXcursor.so.1.0.2
40de1000 40de3000 r-xp /usr/lib/libXdamage.so.1.1.0
40deb000 40ded000 r-xp /usr/lib/libXcomposite.so.1.0.0
40df5000 40df7000 r-xp /usr/lib/libXgesture.so.7.0.0
40dff000 40e02000 r-xp /usr/lib/libXfixes.so.3.1.0
40e0a000 40e13000 r-xp /usr/lib/libXi.so.6.1.0
40e1b000 40e1c000 r-xp /usr/lib/libXinerama.so.1.0.0
40e25000 40e2b000 r-xp /usr/lib/libXrandr.so.2.2.0
40e33000 40e39000 r-xp /usr/lib/libXrender.so.1.3.0
40e41000 40e45000 r-xp /usr/lib/libXtst.so.6.1.0
40e4d000 40e57000 r-xp /usr/lib/libXext.so.6.4.0
40e60000 40ea4000 r-xp /usr/lib/libcurl.so.4.3.0
40ead000 40ec3000 r-xp /lib/libexpat.so.1.6.0
40ecd000 40ee5000 r-xp /usr/lib/libpng12.so.0.50.0
40eed000 40f0a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
40f13000 40fa7000 r-xp /usr/lib/libstdc++.so.6.0.16
40fba000 40fbd000 r-xp /lib/libattr.so.1.1.0
40fc5000 40fc6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
40fce000 40fd3000 r-xp /usr/lib/libffi.so.5.0.10
40fdc000 40fde000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
40fe6000 410b2000 r-xp /usr/lib/libxml2.so.2.7.8
410bf000 410c1000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
410ca000 410cc000 r-xp /usr/lib/journal/libjournal.so.0.1.0
410d4000 410e7000 r-xp /usr/lib/libxcb.so.1.1.0
410f1000 410fa000 r-xp /usr/lib/libcares.so.2.1.0
41103000 41131000 r-xp /usr/lib/libidn.so.11.5.44
41139000 41180000 r-xp /usr/lib/libssl.so.1.0.0
4118c000 4131e000 r-xp /usr/lib/libcrypto.so.1.0.0
41340000 41342000 r-xp /usr/lib/libiri.so
4134a000 41351000 r-xp /lib/libcrypt-2.13.so
41381000 41383000 r-xp /usr/lib/libXau.so.6.0.0
41490000 41494000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4149c000 414a4000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
414a6000 414ab000 r-xp /usr/lib/libappcore-common.so.1.1
414b3000 414b5000 r-xp /usr/lib/libiniparser.so.0
414be000 414c2000 r-xp /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
414d4000 414d8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
414e1000 414e3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
414ec000 414f2000 r-xp /usr/lib/libappsvc.so.0.1.0
414fa000 4151e000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41527000 415f6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4160c000 41616000 r-xp /lib/libnss_files-2.13.so
418b2000 418bd000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
418c8000 418d4000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
418dd000 418fe000 r-xp /usr/lib/libefl-extension.so.0.1.0
41906000 41930000 r-xp /usr/lib/libsensor.so.1.9.5
41939000 41940000 r-xp /usr/lib/libctx-shared.so.0.8.3
41948000 4194d000 r-xp /usr/lib/libctx-client.so.0.8.3
41955000 41967000 r-xp /usr/lib/libefl-assist.so.0.1.0
4196f000 41a27000 r-xp /usr/lib/libcairo.so.2.11200.14
41a32000 41a3c000 r-xp /usr/lib/libsensord-shared.so
41a44000 41a53000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
41a5c000 41a72000 r-xp /usr/lib/libtts.so
41a7b000 41a9e000 r-xp /usr/lib/libui-extension.so.0.1.0
41aa7000 41ab2000 r-xp /usr/lib/libtbm.so.1.0.0
41aba000 41ac8000 r-xp /usr/lib/libGLESv2.so.2.0
41ad1000 41ad2000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41adb000 41ae1000 r-xp /usr/lib/libxcb-render.so.0.0.0
41ae9000 41aec000 r-xp /usr/lib/libEGL.so.1.4
41af4000 41af9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41b01000 41b04000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41b0c000 41b0d000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41b16000 41c9e000 r-xp /usr/lib/libicui18n.so.57.1
41cae000 41db4000 r-xp /usr/lib/libicuuc.so.57.1
41dca000 41dd2000 r-xp /usr/lib/libdrm.so.2.4.0
41dda000 41ddc000 r-xp /usr/lib/libdri2.so.0.0.0
41de4000 41dea000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41df2000 41df7000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41dff000 41e18000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
436b9000 436da000 r-xp /usr/lib/libexif.so.12.3.3
436ed000 436ef000 r-xp /usr/lib/libttrace.so.1.1
436f7000 436fc000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43704000 4370a000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43713000 4371b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43723000 43745000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4374e000 43755000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4375e000 43760000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43768000 4376f000 r-xp /usr/lib/libminizip.so.1.0.0
43777000 43784000 r-xp /usr/lib/libail.so.0.1.0
4378d000 43793000 r-xp /usr/lib/libproc-stat.so.0.2.96
4379b000 4379c000 r-xp /usr/lib/libresponse.so.0.2.96
437a4000 437a9000 r-xp /usr/lib/libsystem.so.0.0.0
437b3000 4387d000 r-xp /usr/lib/libCOREGL.so.4.0
43c22000 43c2d000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c36000 43c3b000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43c43000 43c5a000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43c67000 43c69000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
44571000 44572000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
be8d8000 be8f9000 rw-p [stack]
End of Maps Information

Callstack Information (PID:25525)
Call Stack Count: 11
 0: fclose + 0x8 (0x404d9b58) [/lib/libc.so.6] + 0x5cb58
 1: start_data_collection + 0x110 (0x414c0ae9) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x2ae9
 2: create_base_gui + 0x152 (0x414bfe77) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1e77
 3: app_create + 0x12 (0x414bfc6f) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1c6f
 4: (0x414919c1) [/usr/lib/libcapi-appfw-application.so.0] + 0x19c1
 5: appcore_efl_main + 0x246 (0x40044a5b) [/usr/lib/libappcore-efl.so.1] + 0x3a5b
 6: ui_app_main + 0xb0 (0x41492421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 7: main + 0x116 (0x414bfbf7) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1bf7
 8: (0x40001a53) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1a53
 9: __libc_start_main + 0x114 (0x4049485c) [/lib/libc.so.6] + 0x1785c
10: create_base_gui + 0xe7 (0x40001e0c) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1e0c
End of Call Stack

Package Information
Package Name: org.example.sensordatacollection
Package ID : org.example.sensordatacollection
Version: 1.0.0
Package Type: rpm
App Name: sensordatacollection
App ID: org.example.sensordatacollection
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
PortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 18:19:51.458+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 18:19:51.458+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-10 18:19:51.458+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-10 18:19:51.458+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 18:19:51.458+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
07-10 18:19:51.458+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 18:19:51.463+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 18:19:51.463+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 18:19:51.463+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 18:19:51.463+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-10 18:19:51.463+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-10 18:19:51.463+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 18:19:51.463+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
07-10 18:19:51.463+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-10 18:19:51.463+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-10 18:19:51.468+0800 W/W_HOME  (  824): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
07-10 18:19:51.468+0800 E/W_HOME  (  824): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
07-10 18:19:51.468+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 18:19:51.473+0800 W/MUSIC_CONTROL_SERVICE( 1013): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1013]   [MUSIC_PLAYER_EVENT][0m
07-10 18:19:51.473+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 18:19:51.473+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 18:19:51.478+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 18:19:51.478+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-10 18:19:51.478+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-10 18:19:51.478+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 18:19:51.478+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
07-10 18:19:51.478+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 18:19:51.478+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 18:19:51.478+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 18:19:51.478+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 18:19:51.478+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-10 18:19:51.478+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-10 18:19:51.478+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 18:19:51.478+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
07-10 18:19:51.478+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-10 18:19:51.478+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-10 18:19:51.478+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 18:19:51.478+0800 W/W_HOME  (  824): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
07-10 18:19:51.478+0800 E/W_HOME  (  824): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
07-10 18:19:51.483+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 18:19:51.483+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 18:19:51.483+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 18:19:51.483+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-10 18:19:51.483+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-10 18:19:51.483+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 18:19:51.483+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
07-10 18:19:51.483+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 18:19:51.488+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 18:19:51.488+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 18:19:51.488+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 18:19:51.488+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-10 18:19:51.488+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-10 18:19:51.488+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 18:19:51.488+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
07-10 18:19:51.488+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-10 18:19:51.488+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-10 18:19:51.488+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 18:19:56.158+0800 W/WATCH_CORE(  904): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
07-10 18:19:56.163+0800 I/WATCH_CORE(  904): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
07-10 18:19:56.168+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 18:19:56.183+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 18:19:56.183+0800 I/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
07-10 18:19:56.208+0800 E/wnoti-service( 1050): wnoti-db-utility.c: context_wearonoff_status_cb(1774) > status changed from 2 to 1 
07-10 18:19:56.208+0800 E/wnoti-service( 1050): wnoti-native-client.c: handle_cache_notification(737) > >>
07-10 18:19:56.233+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23423) > wear_monitor_status update[0] = 2 -> 1
07-10 18:19:56.243+0800 W/WECONN  (  499): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_ON
07-10 18:19:56.243+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:354> { state=WC_FEATURE_STATE_ON
07-10 18:19:56.243+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:369> Disconnected manually : 0
07-10 18:19:56.243+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:370> Disconnected by auto switch : 0
07-10 18:19:56.243+0800 W/WECONN  (  499): <wc_manager_get_bearer_state:988> type : 1
07-10 18:19:56.288+0800 W/SHealthService( 1110): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
07-10 18:19:56.328+0800 E/ALARM_MANAGER(  499): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(5), start(10-7-2017, 18:20:01), repeat(0), interval(0), type(-1073741822)
07-10 18:19:56.343+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [499].
07-10 18:19:56.378+0800 I/AUL     (  511): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-10 18:19:56.398+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 15
07-10 18:19:56.418+0800 I/AUL_AMD (  518): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-10 18:19:56.433+0800 I/AUL_AMD (  518): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-10 18:19:56.433+0800 E/ALARM_MANAGER(  511): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1499682001, Mon Jul 10 18:20:01 2017
07-10 18:19:56.433+0800 E/ALARM_MANAGER(  511): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 300190102, next duetime: 1499682001
07-10 18:19:56.433+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(300190102)
07-10 18:19:56.433+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1499691548), due_time(1499682001)
07-10 18:19:56.448+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-10 18:19:56.448+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-10 18:19:56.448+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 10-7-2017, 10:20:01 (UTC).
07-10 18:19:56.448+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-10 18:19:56.448+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-10 18:19:56.458+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-10 18:19:56.458+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-10 18:19:56.468+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:385> }
07-10 18:19:56.468+0800 W/WECONN  (  499): <__wc_feature_wearonoff_monitor_cb:531> }
07-10 18:20:00.578+0800 W/APPS    (  824): apps_main.c: _time_changed_cb(308) >  date : 10->10
07-10 18:20:00.998+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __alarm_handler_idle(1484) > Lock the display not to enter LCD OFF
07-10 18:20:01.063+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-10 18:20:01.108+0800 W/AUL     (  511): app_signal.c: aul_update_freezer_status(456) > aul_update_freezer_status pid(499) type(wakeup)
07-10 18:20:01.113+0800 E/RESOURCED(  635): freezer-process.c: freezer_process_pid_set(150) > Cant find process info for 499
07-10 18:20:01.128+0800 E/ALARM_MANAGER(  499): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.aweconn] : Alarm id [300190102]
07-10 18:20:01.128+0800 W/WECONN  (  499): <__wc_device_try_to_connect_on_wear:171> { state=WC_FEATURE_STATE_ON, vendor=WC_DEVICE_OS_TYPE_ANDROID
07-10 18:20:01.128+0800 W/WECONN  (  499): <wc_manager_get_bearer_state:988> type : 1
07-10 18:20:01.128+0800 W/WECONN  (  499): <__wc_device_try_to_connect:677> connection=WC_CONNECTION_TYPE_BLUETOOTH_SPP_AUTOSWITCH, bearer=WC_BEARER_TYPE_BLUETOOTH
07-10 18:20:01.128+0800 W/WECONN  (  499): <__connect_for_auto_switch:1706> { device=0x42903c78, device->bt_address=1E:F0
07-10 18:20:01.143+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __alarm_expired(1445) > alarm_id[300190102] is expired.
07-10 18:20:01.143+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-10 18:20:01.143+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(300190102)
07-10 18:20:01.143+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-10 18:20:01.163+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 10-7-2017, 12:59:08 (UTC).
07-10 18:20:01.163+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-10 18:20:01.163+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-10 18:20:01.163+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __alarm_handler_idle(1510) > Unlock the display from LCD OFF
07-10 18:20:01.193+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-10 18:20:01.308+0800 W/WECONN  (  499): <__connect_for_auto_switch:1719> }
07-10 18:20:01.308+0800 W/WECONN  (  499):  ### Connect Request [WC_CONNECTION_TYPE_BLUETOOTH_SPP_AUTOSWITCH]
07-10 18:20:01.308+0800 W/WECONN  (  499): <__wc_device_try_to_connect_on_wear:185> }
07-10 18:20:04.248+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-10 18:20:06.458+0800 W/WECONN  (  499): <__on_connect_socket:378> {
07-10 18:20:06.458+0800 W/WECONN  (  499): <__is_device_matched_to:2560> le : , br_edr : 1E:F0, identifier : 1E:F0
07-10 18:20:06.458+0800 W/WECONN  (  499): <__on_connect_socket:383> result(-29359863), state(0)
07-10 18:20:06.458+0800 W/WECONN  (  499): <__on_connect_socket:387> }
07-10 18:20:06.738+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-10 18:20:07.763+0800 W/WATCH_CORE(  904): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
07-10 18:20:07.763+0800 I/WATCH_CORE(  904): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
07-10 18:20:07.763+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 18:20:07.763+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 18:20:07.763+0800 I/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
07-10 18:20:07.778+0800 E/wnoti-service( 1050): wnoti-db-utility.c: context_wearonoff_status_cb(1774) > status changed from 1 to 2 
07-10 18:20:07.788+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23423) > wear_monitor_status update[0] = 1 -> 2
07-10 18:20:07.798+0800 W/WECONN  (  499): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_OFF
07-10 18:20:07.798+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:354> { state=WC_FEATURE_STATE_OFF
07-10 18:20:07.798+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:385> }
07-10 18:20:07.798+0800 W/WECONN  (  499): <__wc_feature_wearonoff_monitor_cb:531> }
07-10 18:20:07.848+0800 W/SHealthService( 1110): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1008[0;m
07-10 18:20:10.633+0800 E/PKGMGR_SERVER(25346): pkgmgr-server.c: main(2242) > package manager server start
07-10 18:20:10.748+0800 E/PKGMGR_SERVER(25346): pkgmgr-server.c: req_cb(1135) > KILL_APP start 
07-10 18:20:10.768+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 14
07-10 18:20:10.778+0800 W/AUL_AMD (  518): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
07-10 18:20:10.778+0800 E/PKGMGR_SERVER(25346): pkgmgr-server.c: req_cb(1154) > CHECK_KILL_APP done[return = 0] 
07-10 18:20:12.583+0800 E/PKGMGR_SERVER(25346): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
07-10 18:20:12.588+0800 E/PKGMGR_SERVER(25346): pkgmgr-server.c: main(2296) > package manager server terminated.
07-10 18:20:18.353+0800 E/PKGMGR  (25459): pkgmgr.c: pkgmgr_client_reinstall(1940) > reinstall pkg start.
07-10 18:20:18.683+0800 E/PKGMGR_SERVER(25461): pkgmgr-server.c: main(2242) > package manager server start
07-10 18:20:18.823+0800 E/PKGMGR  (25461): pkgmgr-internal.c: _get_type_from_zip(735) > can not access to [org.example.sensordatacollection]
07-10 18:20:18.823+0800 E/PKGMGR_SERVER(25461): pkgmgr-server.c: __get_type_from_msg(335) > pkgtype is null for org.example.sensordatacollection 
07-10 18:20:18.823+0800 E/PKGMGR_SERVER(25461): pm-mdm.c: _get_package_info_from_file(1146) > [0;31m[_get_package_info_from_file(): 1146](ret < 0) access() failed. path: org.example.sensordatacollection errno: 2 (No such file or directory)[0;m
07-10 18:20:18.828+0800 E/PKGMGR  (25459): pkgmgr.c: pkgmgr_client_reinstall(2052) > reinstall pkg finish, ret=[254590002]
07-10 18:20:18.833+0800 E/PKGMGR_SERVER(25462): pkgmgr-server.c: queue_job(1944) > INSTALL start, pkg path=[org.example.sensordatacollection]
07-10 18:20:18.833+0800 E/PKGMGR_SERVER(25463): pkgmgr-server.c: queue_job(2138) > COMM_REQ_OBSERVER start, pkgid=[]
07-10 18:20:18.928+0800 E/rpm-installer(25462): rpm-appcore-intf.c: main(120) > ------------------------------------------------
07-10 18:20:18.928+0800 E/rpm-installer(25462): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
07-10 18:20:18.928+0800 E/rpm-installer(25462): rpm-appcore-intf.c: main(122) > ------------------------------------------------
07-10 18:20:18.958+0800 E/PKGMGR_OBSERVER(25463): pkg_observer.c: main(601) > OBSERVER start
07-10 18:20:19.163+0800 E/PKGMGR_OBSERVER(25463): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[254630002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[start] val[update]
07-10 18:20:19.193+0800 W/AUL_AMD (  518): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(org.example.sensordatacollection), key(start), value(update)
07-10 18:20:19.193+0800 W/AUL_AMD (  518): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(997) > __amd_pkgmgrinfo_start_handler
07-10 18:20:19.198+0800 E/PKGMGR_OBSERVER(25463): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[254630002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[install_percent] val[30]
07-10 18:20:19.208+0800 W/W_HOME  (  824): clock_event.c: _pkgmgr_event_cb(210) > Pkg:org.example.sensordatacollection is being updateded:0
07-10 18:20:19.218+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [UPDATE, STARTED]
07-10 18:20:19.238+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [UPDATE, PROCESSING]
07-10 18:20:19.333+0800 W/CERT_SVC(25462): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
07-10 18:20:19.343+0800 E/rpm-installer(25462): coretpk-parser.c: _coretpk_parser_get_manifest_info(1751) > (doc == NULL) xmlParseFile() failed.
07-10 18:20:19.343+0800 E/rpm-installer(25462): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1639) > (pkg_file_info == NULL) pkg_file_info is NULL.
07-10 18:20:19.343+0800 E/rpm-installer(25462): coretpk-installer.c: _coretpk_installer_package_reinstall(6741) > _coretpk_installer_verify_privilege_list failed
07-10 18:20:19.363+0800 E/PKGMGR_PARSER(25462): pkgmgr_parser_signature.c: __ps_check_mdm_policy_by_pkgid(1056) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
07-10 18:20:19.448+0800 E/rpm-installer(25462): coretpk-installer.c: _coretpk_installer_package_reinstall(6795) > _coretpk_installer_package_reinstall(org.example.sensordatacollection) failed.
07-10 18:20:19.458+0800 E/PKGMGR_OBSERVER(25463): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[254630002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[end] val[fail]
07-10 18:20:19.463+0800 E/PKGMGR_OBSERVER(25463): pkg_observer.c: main(620) > OBSERVER end
07-10 18:20:19.473+0800 E/APPS    (  824): pkgmgr.c: _end(777) >  (strcasecmp(val, "ok")) -> _end() return
07-10 18:20:19.473+0800 E/APPS    (  824): pkgmgr.c: _pkgmgr_cb(840) >  pkgmgr_cbs[6].func has errors.
07-10 18:20:19.488+0800 E/PKGMGR_SERVER(25461): pkgmgr-server.c: sighandler(486) > child NORMAL exit [25463]
07-10 18:20:19.488+0800 E/STARTER (  759): pkg-monitor.c: _pkg_monitor_get_mainappid(105) > [_pkg_monitor_get_mainappid:105] Failed to get pkginfo[-1]
07-10 18:20:19.503+0800 W/AUL_AMD (  518): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(org.example.sensordatacollection), key(end), value(fail)
07-10 18:20:19.563+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [UPDATE, COMPLETED]
07-10 18:20:19.563+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7081) > package install complete
07-10 18:20:19.563+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_package_install_event(5035) > 
07-10 18:20:19.563+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(2041) > Found in install_req_list?[0], index[-1]
07-10 18:20:20.583+0800 E/PKGMGR_SERVER(25461): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-10 18:20:21.413+0800 E/rpm-installer(25462): rpm-appcore-intf.c: main(273) > ------------------------------------------------
07-10 18:20:21.413+0800 E/rpm-installer(25462): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
07-10 18:20:21.413+0800 E/rpm-installer(25462): rpm-appcore-intf.c: main(275) > ------------------------------------------------
07-10 18:20:21.423+0800 E/PKGMGR_SERVER(25461): pkgmgr-server.c: sighandler(486) > child NORMAL exit [25462]
07-10 18:20:21.503+0800 E/RESOURCED(  635): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/25462/oom_score_adj failed
07-10 18:20:21.503+0800 E/RESOURCED(  635): proc-main.c: resourced_proc_status_change(1508) > Empty pid or process not exists. 25462
07-10 18:20:21.803+0800 E/PKGMGR  (25512): pkgmgr.c: pkgmgr_client_install(1651) > install pkg start.
07-10 18:20:21.863+0800 E/PKGMGR  (25461): pkgmgr-internal.c: _get_type_from_zip(771) > /opt/usr/apps/tmp/org.example.sensordatacollection-1.0.0-arm.tpk is core
07-10 18:20:21.868+0800 E/PKGMGR  (25461): pkgmgr-internal.c: _get_type_from_zip(771) > /opt/usr/apps/tmp/org.example.sensordatacollection-1.0.0-arm.tpk is core
07-10 18:20:21.868+0800 E/rpm-installer(25461): installer-util.c: _installer_util_delete_dir(420) > (dp == NULL) opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
07-10 18:20:21.878+0800 E/BACKEND_LIB(25461): librpm.c: __is_symlink_file(70) > file is safe
07-10 18:20:21.898+0800 E/PKGMGR_SERVER(25461): pm-mdm.c: _pm_check_mdm_policy(1063) > [0;31m[_pm_check_mdm_policy(): 1063](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
07-10 18:20:21.903+0800 E/PKGMGR  (25512): pkgmgr.c: pkgmgr_client_install(1768) > install pkg finish, ret=[255120002]
07-10 18:20:21.913+0800 E/PKGMGR_SERVER(25514): pkgmgr-server.c: queue_job(1944) > INSTALL start, pkg path=[/opt/usr/apps/tmp/org.example.sensordatacollection-1.0.0-arm.tpk]
07-10 18:20:21.918+0800 E/PKGMGR_SERVER(25515): pkgmgr-server.c: queue_job(2138) > COMM_REQ_OBSERVER start, pkgid=[]
07-10 18:20:22.048+0800 E/rpm-installer(25514): rpm-appcore-intf.c: main(120) > ------------------------------------------------
07-10 18:20:22.048+0800 E/rpm-installer(25514): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
07-10 18:20:22.048+0800 E/rpm-installer(25514): rpm-appcore-intf.c: main(122) > ------------------------------------------------
07-10 18:20:22.078+0800 E/PKGMGR_OBSERVER(25515): pkg_observer.c: main(601) > OBSERVER start
07-10 18:20:22.208+0800 E/rpm-installer(25514): rpm-appcore-intf.c: main(207) > [/opt/usr/apps/tmp/org.example.sensordatacollection-1.0.0-arm.tpk] is tpk package.
07-10 18:20:22.223+0800 E/rpm-installer(25514): coretpk-parser.c: __coretpk_parser_get_value(1713) > (result_value == NULL) [install-location] is empty.
07-10 18:20:22.223+0800 E/rpm-installer(25514): coretpk-parser.c: __coretpk_parser_get_value_list(1670) > (ret == 1) [//*[name() ='privileges']/*[name()='privilege']] is empty.
07-10 18:20:22.223+0800 E/rpm-installer(25514): coretpk-parser.c: _coretpk_parser_is_widget(1586) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget'])
07-10 18:20:22.223+0800 E/rpm-installer(25514): coretpk-parser.c: _coretpk_parser_is_custom_clock(1480) > (ret == 1) metadata(watchface) is empty.
07-10 18:20:22.228+0800 E/rpm-installer(25514): installer-util.c: _installer_util_delete_dir(420) > (dp == NULL) opendir(/opt/usr/data/pkgmgr/org.example.sensordatacollection/) failed. [2][No such file or directory]
07-10 18:20:22.228+0800 E/rpm-installer(25514): coretpk-installer.c: _coretpk_installer_install_package(3579) > Deletion failed: [/opt/usr/data/pkgmgr/org.example.sensordatacollection/]
07-10 18:20:22.343+0800 E/PKGMGR_OBSERVER(25515): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[255150002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[start] val[install]
07-10 18:20:22.358+0800 E/APPS    (  824): pkgmgr.c: _start(495) >  (_exist_request_in_list(package)) -> _start() return
07-10 18:20:22.358+0800 E/APPS    (  824): pkgmgr.c: _pkgmgr_cb(840) >  pkgmgr_cbs[0].func has errors.
07-10 18:20:22.378+0800 W/AUL_AMD (  518): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(org.example.sensordatacollection), key(start), value(install)
07-10 18:20:22.383+0800 E/PKGMGR_OBSERVER(25515): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[255150002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[install_percent] val[30]
07-10 18:20:22.408+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, STARTED]
07-10 18:20:22.433+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, PROCESSING]
07-10 18:20:22.533+0800 W/CERT_SVC(25514): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
07-10 18:20:22.558+0800 E/rpm-installer(25514): coretpk-parser.c: __coretpk_parser_verify_metadata(48) > (ret == 1) metadata is empty.
07-10 18:20:22.558+0800 E/rpm-installer(25514): coretpk-parser.c: __coretpk_parser_append_path(417) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
07-10 18:20:22.558+0800 E/rpm-installer(25514): coretpk-parser.c: __coretpk_parser_append_path(417) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
07-10 18:20:22.558+0800 E/rpm-installer(25514): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(541) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
07-10 18:20:22.583+0800 E/PKGMGR_SERVER(25461): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-10 18:20:22.623+0800 E/PKGMGR_PARSER(25514): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2167) > Manifest is Valid
07-10 18:20:22.623+0800 E/PKGMGR_PARSER(25514): pkgmgr_parser.c: __parse_manifest_for_installation(1910) > parsing manifest for installation: /opt/share/packages/org.example.sensordatacollection.xml
07-10 18:20:22.633+0800 E/PKGMGR_PARSER(25514): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
07-10 18:20:22.633+0800 E/PKGMGR_PARSER(25514): pkgmgr_parser.c: __ps_process_tag(866) > tag is NULL
07-10 18:20:22.828+0800 I/efl-extension(25514): efl_extension.c: eext_mod_init(40) > Init
07-10 18:20:22.828+0800 I/efl-extension(25514): efl_extension.c: eext_mod_shutdown(46) > Shutdown
07-10 18:20:22.918+0800 E/PKGMGR_PARSER(25514): pkgmgr_parser.c: __parse_manifest_for_installation(1952) > parsing manifest for installation Done
07-10 18:20:22.948+0800 E/PKGMGR_CERT(25514): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
07-10 18:20:22.953+0800 E/PKGMGR_CERT(25514): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 120
07-10 18:20:22.953+0800 E/PKGMGR_CERT(25514): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 120
07-10 18:20:22.953+0800 E/PKGMGR_CERT(25514): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 29 6
07-10 18:20:22.953+0800 E/PKGMGR_CERT(25514): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 21 14
07-10 18:20:22.953+0800 E/PKGMGR_CERT(25514): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 14
07-10 18:20:22.958+0800 E/PKGMGR_CERT(25514): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 30 6
07-10 18:20:22.968+0800 E/PKGMGR_CERT(25514): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(575) > Transaction Commit and End
07-10 18:20:22.978+0800 E/PKGMGR_OBSERVER(25515): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[255150002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[install_percent] val[60]
07-10 18:20:23.008+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, PROCESSING]
07-10 18:20:23.038+0800 E/rpm-installer(25514): installer-util.c: _installer_util_get_configuration_value(601) > [signature]=[on]
07-10 18:20:23.048+0800 E/rpm-installer(25514): coretpk-installer.c: _coretpk_installer_apply_smack(3199) > groupid = [z0QlgvtZWc7MUAsAHX1kZCd6NyfN6kalPinZVqoqrqE=] for shared/trusted.
07-10 18:20:23.088+0800 E/rpm-installer(25514): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
07-10 18:20:23.098+0800 E/PKGMGR_OBSERVER(25515): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[255150002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[install_percent] val[100]
07-10 18:20:23.123+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, PROCESSING]
07-10 18:20:23.153+0800 E/rpm-installer(25514): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
07-10 18:20:23.243+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 25115 pgid = 25115
07-10 18:20:23.243+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
07-10 18:20:23.333+0800 I/AUL_AMD (  518): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 25115
07-10 18:20:23.333+0800 W/AUL     (  518): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(25115)
07-10 18:20:23.398+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-10 18:20:23.398+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 25218 pgid = -1
07-10 18:20:23.398+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
07-10 18:20:23.398+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-10 18:20:23.433+0800 I/AUL_AMD (  518): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 25113
07-10 18:20:23.433+0800 W/AUL     (  518): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(25113)
07-10 18:20:23.438+0800 I/AUL_AMD (  518): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 25218
07-10 18:20:23.438+0800 W/AUL     (  518): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(25218)
07-10 18:20:23.528+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-10 18:20:24.153+0800 I/efl-extension(25526): efl_extension.c: eext_mod_init(40) > Init
07-10 18:20:24.163+0800 I/AUL_PAD (25525): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-10 18:20:24.298+0800 I/UXT     (25526): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-10 18:20:24.413+0800 I/AUL_PAD (25526): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-10 18:20:24.448+0800 E/MALI    (25526): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-10 18:20:24.448+0800 E/MALI    (25526): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-10 18:20:24.448+0800 E/MALI    (25526): [gpu-ddk] devel/graphics_drv/r4p0
07-10 18:20:24.448+0800 E/MALI    (25526): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-10 18:20:24.448+0800 E/MALI    (25526): [coregl] devel/graphics_engine/master
07-10 18:20:24.448+0800 E/MALI    (25526): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-10 18:20:24.448+0800 E/MALI    (25526): 
07-10 18:20:24.583+0800 E/PKGMGR_SERVER(25461): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-10 18:20:25.373+0800 E/PKGMGR_OBSERVER(25515): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[255150002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[end] val[ok]
07-10 18:20:25.393+0800 W/W_HOME  (  824): clock_event.c: _pkgmgr_event_cb(247) > Pkg:org.example.sensordatacollection is updated, need to check validation
07-10 18:20:25.393+0800 W/W_HOME  (  824): clock_event.c: _pkgmgr_event_cb(251) > attacheck clock:com.samsung.watchface
07-10 18:20:25.448+0800 W/AUL_AMD (  518): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(org.example.sensordatacollection), key(end), value(ok)
07-10 18:20:25.458+0800 E/PKGMGR_INFO(25515): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(1026) > callback is stopped.
07-10 18:20:25.463+0800 W/SVOICE  ( 3159): DomainAppState.cpp: operator()(64) > [0;32mINFO: Apps info changed. SetUploadSyncCondition[0;m
07-10 18:20:25.473+0800 W/SVOICE  ( 3159): PreferenceKey.cpp: SetUploadSyncCondition(551) > [0;32mINFO: UploadManager need to Sync : 1[0;m
07-10 18:20:25.473+0800 E/PKGMGR_OBSERVER(25515): pkg_observer.c: main(620) > OBSERVER end
07-10 18:20:25.498+0800 E/PKGMGR_SERVER(25461): pkgmgr-server.c: sighandler(486) > child NORMAL exit [25515]
07-10 18:20:25.523+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, COMPLETED]
07-10 18:20:25.523+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7081) > package install complete
07-10 18:20:25.523+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_package_install_event(5035) > 
07-10 18:20:25.523+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(2041) > Found in install_req_list?[0], index[-1]
07-10 18:20:25.523+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_package_install_event(5061) > triggered from Gear itself.
07-10 18:20:25.563+0800 E/STARTER (  759): pkg-monitor.c: _pkg_monitor_get_metadata(136) > [_pkg_monitor_get_metadata:136] Failed to get metadata value[-2]
07-10 18:20:25.598+0800 E/WMS     (  516): wms_db.c: wms_db_package_event_insert_record(190) > 
07-10 18:20:25.608+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2887) > send_install_response completed : END
07-10 18:20:25.623+0800 E/PKGMGR_INFO(  513): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(922) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-10 18:20:25.623+0800 W/MM_CAMCORDER(25524): mm_camcorder_internal.c: _mmcamcorder_constructor(203) >  start
07-10 18:20:25.623+0800 W/MM_CAMCORDER(25524): mm_camcorder_internal.c: _mmcamcorder_constructor(213) >  done
07-10 18:20:25.628+0800 I/efl-extension(25524): efl_extension.c: eext_mod_init(40) > Init
07-10 18:20:25.643+0800 W/APPS    (  824): AppsViewNecklace.cpp: onTouchEventCancel(4949) >  touch cancel
07-10 18:20:26.498+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.533+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.533+0800 E/AUL     (25524): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:20:26.533+0800 E/AUL     (25524): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:20:26.553+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.583+0800 E/PKGMGR_SERVER(25461): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-10 18:20:26.583+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.593+0800 E/AUL     (25524): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:20:26.593+0800 E/AUL     (25524): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:20:26.613+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.643+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.643+0800 E/AUL     (25524): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:20:26.643+0800 E/AUL     (25524): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:20:26.653+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.668+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.668+0800 E/AUL     (25524): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:20:26.668+0800 E/AUL     (25524): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:20:26.683+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.693+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.693+0800 E/AUL     (25524): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:20:26.698+0800 E/AUL     (25524): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:20:26.713+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.723+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.723+0800 E/AUL     (25524): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:20:26.728+0800 E/AUL     (25524): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:20:26.738+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.753+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.753+0800 E/AUL     (25524): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:20:26.753+0800 E/AUL     (25524): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:20:26.768+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.783+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.783+0800 E/AUL     (25524): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:20:26.783+0800 E/AUL     (25524): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:20:26.813+0800 I/UXT     (25524): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-10 18:20:26.943+0800 E/MALI    (25524): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-10 18:20:26.948+0800 E/MALI    (25524): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-10 18:20:26.948+0800 E/MALI    (25524): [gpu-ddk] devel/graphics_drv/r4p0
07-10 18:20:26.948+0800 E/MALI    (25524): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-10 18:20:26.948+0800 E/MALI    (25524): [coregl] devel/graphics_engine/master
07-10 18:20:26.948+0800 E/MALI    (25524): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-10 18:20:26.948+0800 E/MALI    (25524): CHKѩ
07-10 18:20:27.643+0800 E/rpm-installer(25514): rpm-appcore-intf.c: main(273) > ------------------------------------------------
07-10 18:20:27.643+0800 E/rpm-installer(25514): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
07-10 18:20:27.643+0800 E/rpm-installer(25514): rpm-appcore-intf.c: main(275) > ------------------------------------------------
07-10 18:20:27.658+0800 E/PKGMGR_SERVER(25461): pkgmgr-server.c: sighandler(486) > child NORMAL exit [25514]
07-10 18:20:27.733+0800 E/RESOURCED(  635): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/25514/oom_score_adj failed
07-10 18:20:27.733+0800 E/RESOURCED(  635): proc-main.c: resourced_proc_status_change(1508) > Empty pid or process not exists. 25514
07-10 18:20:27.813+0800 I/MALI    (25524): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x360]
07-10 18:20:27.818+0800 E/MALI    (25524): egl_mali.c: __egl_mali_post_to_window_surface(1183) > MALI_ERR_EARLY_OUT - Don't need to add frame callback because frame is unmodified
07-10 18:20:27.833+0800 I/AUL     (25535): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
07-10 18:20:27.848+0800 I/AUL     (25535): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:27.848+0800 E/AUL     (25535): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:20:27.853+0800 E/AUL     (25535): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:20:28.583+0800 E/PKGMGR_SERVER(25461): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
07-10 18:20:28.583+0800 E/PKGMGR_SERVER(25461): pkgmgr-server.c: main(2296) > package manager server terminated.
07-10 18:20:30.823+0800 W/AUL     (25601): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-10 18:20:30.828+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 0
07-10 18:20:30.878+0800 I/AUL_AMD (  518): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
07-10 18:20:30.898+0800 I/AUL_AMD (  518): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
07-10 18:20:30.898+0800 E/AUL_AMD (  518): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
07-10 18:20:30.898+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(1782) > caller pid : 25601
07-10 18:20:30.923+0800 E/RESOURCED(  635): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 3
07-10 18:20:30.923+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(2218) > pad pid(-5)
07-10 18:20:30.923+0800 W/AUL_PAD ( 1342): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-10 18:20:30.923+0800 W/AUL_PAD ( 1342): launchpad.c: __send_result_to_caller(272) > Check app launching
07-10 18:20:30.928+0800 W/AUL_PAD (25525): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-10 18:20:30.928+0800 W/AUL_PAD (25525): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-10 18:20:30.928+0800 W/AUL_PAD (25525): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-10 18:20:30.928+0800 W/AUL_PAD (25525): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-10 18:20:30.993+0800 I/efl-extension(25525): efl_extension.c: eext_mod_init(40) > Init
07-10 18:20:30.998+0800 I/UXT     (25525): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-10 18:20:31.003+0800 W/AUL_PAD (25525): launchpad_loader.c: main(690) > [candidate] dlsym
07-10 18:20:31.003+0800 W/AUL_PAD (25525): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-10 18:20:31.003+0800 I/CAPI_APPFW_APPLICATION(25525): app_main.c: ui_app_main(704) > app_efl_main
07-10 18:20:31.008+0800 I/CAPI_APPFW_APPLICATION(25525): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-10 18:20:31.028+0800 W/AUL     (  518): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(25525) type(uiapp) bg(0)
07-10 18:20:31.028+0800 W/AUL     (25601): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25525)
07-10 18:20:31.028+0800 W/AUL_AMD (  518): amd_status.c: __socket_monitor_cb(1277) > (25525) was created
07-10 18:20:31.063+0800 W/STARTER (  759): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [25525]
07-10 18:20:31.223+0800 I/efl-extension(25525): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-10 18:20:31.223+0800 I/efl-extension(25525): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-10 18:20:31.223+0800 I/efl-extension(25525): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-10 18:20:31.223+0800 I/efl-extension(25525): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-10 18:20:31.223+0800 I/efl-extension(25525): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x41879db0, elm_image, _activated_obj : 0x0, activated : 1
07-10 18:20:31.228+0800 E/EFL     (25525): elementary<25525> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-10 18:20:31.233+0800 E/EFL     (25525): elementary<25525> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x4187a218) will be pushed
07-10 18:20:31.233+0800 I/efl-extension(25525): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x418909a0]'s widget[0x4187b6a8] to layout widget[0x4187a218]
07-10 18:20:31.238+0800 E/EFL     (25525): elementary<25525> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e9388 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-10 18:20:31.238+0800 E/EFL     (25525): elementary<25525> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e9388 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-10 18:20:31.243+0800 I/efl-extension(25525): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-10 18:20:31.588+0800 W/CRASH_MANAGER(25603): worker.c: worker_job(1205) > 112552573656e149968203
