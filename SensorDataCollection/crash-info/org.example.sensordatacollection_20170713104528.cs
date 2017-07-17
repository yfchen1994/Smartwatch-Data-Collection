S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 18716
Date: 2017-07-13 10:45:28+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 18716, uid 5000)

Register Information
r0   = 0xbe83b32d, r1   = 0x00000000
r2   = 0x9a30d500, r3   = 0x00000000
r4   = 0x44b71558, r5   = 0x44b51d38
r6   = 0x44b4bd58, r7   = 0xbe83b010
r8   = 0x00000000, r9   = 0x44b75108
r10  = 0x44b84368, fp   = 0x00000001
ip   = 0x413d1dec, sp   = 0xbe83afe0
lr   = 0x413c0135, pc   = 0x404f2cb8
cpsr = 0x80000010

Memory Information
MemTotal:   491132 KB
MemFree:      8576 KB
Buffers:     10172 KB
Cached:     131828 KB
VmPeak:      82608 KB
VmSize:      81588 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23520 KB
VmRSS:       23520 KB
VmData:      17884 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25500 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 18716 TID = 18716
18716 18809 

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
41390000 41394000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4139c000 413a4000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
413a6000 413ab000 r-xp /usr/lib/libappcore-common.so.1.1
413b3000 413b5000 r-xp /usr/lib/libiniparser.so.0
413be000 413c2000 r-xp /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
413d4000 413d8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
413e1000 413e3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
413ec000 413f2000 r-xp /usr/lib/libappsvc.so.0.1.0
413fa000 4141e000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41427000 414f6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4150c000 41516000 r-xp /lib/libnss_files-2.13.so
416b2000 416bd000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
416c8000 416cd000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
416d5000 416e1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
416ea000 4170b000 r-xp /usr/lib/libefl-extension.so.0.1.0
41713000 41718000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41720000 4174a000 r-xp /usr/lib/libsensor.so.1.9.5
41753000 4175a000 r-xp /usr/lib/libctx-shared.so.0.8.3
41762000 41767000 r-xp /usr/lib/libctx-client.so.0.8.3
4176f000 41781000 r-xp /usr/lib/libefl-assist.so.0.1.0
41789000 41793000 r-xp /usr/lib/libsensord-shared.so
4179b000 417aa000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
417b3000 417c9000 r-xp /usr/lib/libtts.so
417d2000 417f5000 r-xp /usr/lib/libui-extension.so.0.1.0
417fe000 417ff000 r-xp /usr/lib/libresponse.so.0.2.96
41807000 4193b000 rw-p [heap]
4193b000 419f3000 r-xp /usr/lib/libcairo.so.2.11200.14
419fe000 41a09000 r-xp /usr/lib/libtbm.so.1.0.0
41a11000 41a1f000 r-xp /usr/lib/libGLESv2.so.2.0
41a28000 41a29000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41a32000 41a38000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a40000 41a43000 r-xp /usr/lib/libEGL.so.1.4
41a4b000 41a4e000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41a56000 41a57000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41a60000 41be8000 r-xp /usr/lib/libicui18n.so.57.1
41bf8000 41cfe000 r-xp /usr/lib/libicuuc.so.57.1
41d14000 41d1c000 r-xp /usr/lib/libdrm.so.2.4.0
41d24000 41d26000 r-xp /usr/lib/libdri2.so.0.0.0
41d2e000 41d34000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41d3c000 41d41000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41d49000 41d62000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
43603000 43624000 r-xp /usr/lib/libexif.so.12.3.3
43637000 43639000 r-xp /usr/lib/libttrace.so.1.1
43641000 43646000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
4364e000 43654000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4365d000 43665000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4366d000 4368f000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43698000 4369f000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
436a8000 436aa000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
436b2000 436b9000 r-xp /usr/lib/libminizip.so.1.0.0
436c1000 436ce000 r-xp /usr/lib/libail.so.0.1.0
436d7000 436dd000 r-xp /usr/lib/libproc-stat.so.0.2.96
436e5000 436ea000 r-xp /usr/lib/libsystem.so.0.0.0
436f4000 437be000 r-xp /usr/lib/libCOREGL.so.4.0
43c63000 43c6e000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c77000 43c7c000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43c84000 43c9b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43ca8000 43caa000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43cb3000 444b2000 rw-p [stack:18809]
444b2000 444b3000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
4485b000 4485c000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44867000 4486c000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
4487a000 44882000 r-xp /usr/lib/libfeedback.so.0.1.4
44884000 44885000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
4488d000 4488f000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
44897000 448a2000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
448aa000 448b1000 r-xp /usr/lib/libmmfcommon.so.0.0.0
448b9000 448d1000 r-xp /usr/lib/libmmfsound.so.0.1.0
448e2000 448e6000 r-xp /usr/lib/libmmfsession.so.0.0.0
448ef000 448fa000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
44907000 4490b000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
44913000 44929000 r-xp /usr/lib/libavsysaudio.so.0.0.1
44931000 44992000 r-xp /usr/lib/libasound.so.2.0.0
4499c000 4499f000 r-xp /usr/lib/libpulse-simple.so.0.0.4
449a7000 449df000 r-xp /usr/lib/libpulse.so.0.16.2
449e0000 449e3000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
449eb000 44a33000 r-xp /usr/lib/libmdm.so.1.2.62
44a34000 44a37000 r-xp /usr/lib/libtinycompress.so.0.0.0
44a3f000 44a44000 r-xp /usr/lib/libjson.so.0.0.1
44a4c000 44a95000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
44a9e000 44ae5000 r-xp /usr/lib/libsndfile.so.1.0.26
44af1000 44b00000 r-xp /usr/lib/libmdm-common.so.1.1.22
44b09000 44b2b000 r-xp /usr/lib/libvorbis.so.0.4.3
44b33000 44b37000 r-xp /usr/lib/libogg.so.0.7.1
44c3f000 44c4f000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
be81b000 be83c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18716)
Call Stack Count: 1
 0: strcmp + 0x4 (0x404f2cb8) [/lib/libc.so.6] + 0x75cb8
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
 aul_send_app_status_change_signal app(com.samsung.w-home) pid(806) status(bg) type(uiapp)
07-13 10:45:19.911+0800 W/STARTER (  741): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[806] goes to (4)
07-13 10:45:19.911+0800 E/STARTER (  741): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 806)'s state(4)
07-13 10:45:19.916+0800 W/AUL_AMD (  520): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-13 10:45:19.916+0800 W/AUL_AMD (  520): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
07-13 10:45:19.916+0800 W/AUL     (  520): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-taskmanager) pid(18415) status(fg) type(uiapp)
07-13 10:45:19.916+0800 W/STARTER (  741): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[18415] goes to (3)
07-13 10:45:19.971+0800 I/APP_CORE(18415): appcore-efl.c: __do_app(453) > [APP 18415] Event: RESUME State: RUNNING
07-13 10:45:19.986+0800 W/W_HOME  (  806): win.c: win_back_gesture_disable_set(173) > enable back gesture
07-13 10:45:19.986+0800 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-13 10:45:19.986+0800 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-13 10:45:19.986+0800 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-13 10:45:19.986+0800 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-13 10:45:19.986+0800 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-13 10:45:19.986+0800 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-13 10:45:19.986+0800 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-13 10:45:19.986+0800 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-13 10:45:19.991+0800 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-13 10:45:19.991+0800 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-13 10:45:19.991+0800 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-13 10:45:19.991+0800 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-13 10:45:19.991+0800 I/MESSAGE_PORT(  480): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-13 10:45:19.991+0800 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-13 10:45:19.991+0800 I/MESSAGE_PORT(  480): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-13 10:45:19.991+0800 I/MESSAGE_PORT(  480): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-13 10:45:19.991+0800 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-13 10:45:19.991+0800 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-13 10:45:19.991+0800 E/CAPI_APPFW_APP_CONTROL( 1010): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-13 10:45:19.991+0800 W/MUSIC_CONTROL_SERVICE( 1010): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1010]   [com.samsung.w-home]register msg port [false][0m
07-13 10:45:20.006+0800 W/W_INDICATOR(  742): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-13 10:45:20.006+0800 I/wnotib  (  806): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
07-13 10:45:20.011+0800 E/wnotib  (  806): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-13 10:45:20.011+0800 W/wnotib  (  806): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [1], notiboard card appending count [2].
07-13 10:45:20.086+0800 W/APPS    (  806): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
07-13 10:45:20.346+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
07-13 10:45:20.351+0800 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18415
07-13 10:45:20.356+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 12
07-13 10:45:20.366+0800 E/AUL     (  520): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-13 10:45:20.371+0800 I/MALI    (18415): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x41d04098] swap changed from async to sync
07-13 10:45:20.371+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
07-13 10:45:20.381+0800 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18415
07-13 10:45:20.381+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 12
07-13 10:45:20.506+0800 I/APP_CORE(  806): appcore-efl.c: __do_app(453) > [APP 806] Event: MEM_FLUSH State: PAUSED
07-13 10:45:20.711+0800 I/efl-extension(18792): efl_extension.c: eext_mod_init(40) > Init
07-13 10:45:20.806+0800 I/UXT     (18792): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-13 10:45:20.831+0800 E/EFL     (18415): ecore_x<18415> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=52405160 button=1
07-13 10:45:20.831+0800 E/EFL     (18415): elementary<18415> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x454988c0 : elm_scroller] mouse move
07-13 10:45:20.851+0800 E/EFL     (18415): ecore_x<18415> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=52405181 button=1
07-13 10:45:20.876+0800 E/wnoti-service( 1049): wnoti-db-utility.c: context_wearonoff_status_cb(1774) > status changed from 2 to 1 
07-13 10:45:20.876+0800 E/wnoti-service( 1049): wnoti-native-client.c: handle_cache_notification(737) > >>
07-13 10:45:20.881+0800 E/WMS     (  518): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23423) > wear_monitor_status update[0] = 2 -> 1
07-13 10:45:20.881+0800 W/WECONN  (  499): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_ON
07-13 10:45:20.881+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:354> { state=WC_FEATURE_STATE_ON
07-13 10:45:20.881+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:369> Disconnected manually : 0
07-13 10:45:20.881+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:370> Disconnected by auto switch : 0
07-13 10:45:20.881+0800 W/WECONN  (  499): <wc_manager_get_bearer_state:988> type : 1
07-13 10:45:20.891+0800 W/WATCH_CORE(  929): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
07-13 10:45:20.891+0800 I/WATCH_CORE(  929): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
07-13 10:45:20.891+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:45:20.891+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:45:20.891+0800 I/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
07-13 10:45:20.906+0800 E/ALARM_MANAGER(  499): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(5), start(13-7-2017, 10:45:26), repeat(0), interval(0), type(-1073741822)
07-13 10:45:20.911+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [499].
07-13 10:45:20.911+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
07-13 10:45:20.921+0800 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
07-13 10:45:20.926+0800 W/AUL     (18415): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-13 10:45:20.926+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 0
07-13 10:45:20.926+0800 W/AUL_AMD (  520): amd_launch.c: _start_app(1782) > caller pid : 18415
07-13 10:45:20.926+0800 I/AUL_AMD (  520): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
07-13 10:45:20.936+0800 I/AUL     (  516): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-13 10:45:20.941+0800 W/AUL_AMD (  520): amd_launch.c: _start_app(2218) > pad pid(-5)
07-13 10:45:20.946+0800 E/RESOURCED(  605): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 4
07-13 10:45:20.946+0800 W/AUL_PAD ( 1314): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-13 10:45:20.946+0800 W/AUL_PAD ( 1314): launchpad.c: __send_result_to_caller(272) > Check app launching
07-13 10:45:20.951+0800 W/AUL_PAD (18716): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-13 10:45:20.951+0800 W/AUL_PAD (18716): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-13 10:45:20.951+0800 W/AUL_PAD (18716): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-13 10:45:20.951+0800 W/AUL_PAD (18716): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-13 10:45:20.956+0800 W/SHealthService( 1115): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
07-13 10:45:21.016+0800 I/AUL_PAD (18792): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-13 10:45:21.046+0800 I/efl-extension(18716): efl_extension.c: eext_mod_init(40) > Init
07-13 10:45:21.046+0800 I/UXT     (18716): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-13 10:45:21.061+0800 W/AUL_PAD (18716): launchpad_loader.c: main(690) > [candidate] dlsym
07-13 10:45:21.061+0800 W/AUL_PAD (18716): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-13 10:45:21.061+0800 I/CAPI_APPFW_APPLICATION(18716): app_main.c: ui_app_main(704) > app_efl_main
07-13 10:45:21.066+0800 I/CAPI_APPFW_APPLICATION(18716): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-13 10:45:21.151+0800 W/AUL     (  520): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(18716) type(uiapp) bg(0)
07-13 10:45:21.151+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 15
07-13 10:45:21.151+0800 W/STARTER (  741): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [18716]
07-13 10:45:21.151+0800 W/AUL     (18415): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18716)
07-13 10:45:21.151+0800 E/W_TASKMANAGER(18415): task.c: taskmanager_launch_task_info(1075) > [taskmanager_launch_task_info:1075] _launch_app() failed(18716)
07-13 10:45:21.161+0800 I/AUL_AMD (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-13 10:45:21.171+0800 I/AUL_AMD (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-13 10:45:21.176+0800 W/AUL_AMD (  520): amd_status.c: __socket_monitor_cb(1277) > (18716) was created
07-13 10:45:21.176+0800 E/AUL     (  520): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-13 10:45:21.176+0800 E/ALARM_MANAGER(  516): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1499913926, Thu Jul 13 10:45:26 2017
07-13 10:45:21.176+0800 E/ALARM_MANAGER(  516): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 2134521740, next duetime: 1499913926
07-13 10:45:21.176+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(2134521740)
07-13 10:45:21.176+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1499918348), due_time(1499913926)
07-13 10:45:21.181+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-13 10:45:21.191+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-13 10:45:21.191+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 13-7-2017, 02:45:26 (UTC).
07-13 10:45:21.191+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-13 10:45:21.191+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-13 10:45:21.196+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-13 10:45:21.196+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-13 10:45:21.206+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:385> }
07-13 10:45:21.206+0800 W/WECONN  (  499): <__wc_feature_wearonoff_monitor_cb:531> }
07-13 10:45:21.291+0800 I/efl-extension(18716): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-13 10:45:21.291+0800 I/efl-extension(18716): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-13 10:45:21.291+0800 I/efl-extension(18716): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-13 10:45:21.296+0800 I/efl-extension(18716): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-13 10:45:21.296+0800 I/efl-extension(18716): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x437e4fa8, elm_image, _activated_obj : 0x0, activated : 1
07-13 10:45:21.296+0800 E/EFL     (18716): elementary<18716> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-13 10:45:21.301+0800 E/EFL     (18716): elementary<18716> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x437e5410) will be pushed
07-13 10:45:21.301+0800 I/efl-extension(18716): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x438a9600]'s widget[0x437e68a0] to layout widget[0x437e5410]
07-13 10:45:21.301+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437d4910 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:45:21.306+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437d4910 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-13 10:45:21.306+0800 I/efl-extension(18716): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-13 10:45:21.336+0800 I/APP_CORE(18716): appcore-efl.c: __do_app(453) > [APP 18716] Event: RESET State: CREATED
07-13 10:45:21.336+0800 I/CAPI_APPFW_APPLICATION(18716): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
07-13 10:45:21.371+0800 I/MALI    (18415): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x41d04098] swap changed from sync to async
07-13 10:45:21.376+0800 I/APP_CORE(18716): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
07-13 10:45:21.376+0800 I/APP_CORE(18716): appcore-efl.c: __do_app(524) > [APP 18716] Initial Launching, call the resume_cb
07-13 10:45:21.376+0800 I/CAPI_APPFW_APPLICATION(18716): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
07-13 10:45:21.381+0800 W/APP_CORE(18716): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1a00002
07-13 10:45:21.386+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437d4910 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:45:21.386+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437d4910 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
07-13 10:45:21.426+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437d4910 : elm_genlist] mx(0), my(130), minx(0), miny(0), px(0), py(0)
07-13 10:45:21.426+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437d4910 : elm_genlist] cw(360), ch(490), pw(360), ph(360)
07-13 10:45:21.446+0800 E/MALI    (18792): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-13 10:45:21.446+0800 E/MALI    (18792): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-13 10:45:21.446+0800 E/MALI    (18792): [gpu-ddk] devel/graphics_drv/r4p0
07-13 10:45:21.446+0800 E/MALI    (18792): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-13 10:45:21.446+0800 E/MALI    (18792): [coregl] devel/graphics_engine/master
07-13 10:45:21.446+0800 E/MALI    (18792): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-13 10:45:21.536+0800 W/STARTER (  741): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[18415] goes to (4)
07-13 10:45:21.536+0800 W/AUL     (  520): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-taskmanager) pid(18415) status(bg) type(uiapp)
07-13 10:45:21.556+0800 W/STARTER (  741): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[18716] goes to (3)
07-13 10:45:21.556+0800 W/AUL     (  520): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.sensordatacollection) pid(18716) status(fg) type(uiapp)
07-13 10:45:21.611+0800 I/APP_CORE(18716): appcore-efl.c: __do_app(453) > [APP 18716] Event: RESUME State: RUNNING
07-13 10:45:21.616+0800 E/TBM     (  462): tbm_bufmgr.c: _tgl_destroy(141) > [libtbm:462] error(Device or resource busy) _tgl_destroy:141 key:41
07-13 10:45:21.671+0800 I/APP_CORE(18415): appcore-efl.c: __do_app(453) > [APP 18415] Event: PAUSE State: RUNNING
07-13 10:45:21.676+0800 I/CAPI_APPFW_APPLICATION(18415): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-13 10:45:21.881+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 22
07-13 10:45:21.881+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(999) > app status : 4
07-13 10:45:21.886+0800 E/APP_CORE(18415): appcore.c: __del_vconf(453) > [FAILED]vconfkey_ignore_key_changed
07-13 10:45:21.886+0800 I/APP_CORE(18415): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
07-13 10:45:21.901+0800 I/CAPI_APPFW_APPLICATION(18415): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
07-13 10:45:21.931+0800 E/AUL     (  520): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-13 10:45:21.936+0800 I/efl-extension(18415): efl_extension_rotary.c: _object_deleted_cb(589) > In: data: 0x454988c0, obj: 0x454988c0
07-13 10:45:21.976+0800 I/efl-extension(18415): efl_extension_rotary.c: _remove_ecore_handlers(571) > In
07-13 10:45:21.976+0800 I/efl-extension(18415): efl_extension_rotary.c: _remove_ecore_handlers(576) > removed _motion_handler
07-13 10:45:21.976+0800 I/efl-extension(18415): efl_extension_rotary.c: _remove_ecore_handlers(582) > removed _rotate_handler
07-13 10:45:21.976+0800 I/efl-extension(18415): efl_extension_rotary.c: _object_deleted_cb(618) > done
07-13 10:45:21.976+0800 E/EFL     (18415): elementary<18415> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x454988c0 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:45:21.976+0800 E/EFL     (18415): elementary<18415> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x454988c0 : elm_scroller] cw(0), ch(0), pw(360), ph(360)
07-13 10:45:21.981+0800 E/EFL     (18415): elementary<18415> elm_interface_scrollable.c:1965 _elm_scroll_content_region_show_internal() [0x454988c0 : elm_scroller] x(0), y(0), nx(0), px(0), ny(0) py(0)
07-13 10:45:21.986+0800 I/efl-extension(18415): efl_extension_rotary.c: _activated_obj_del_cb(624) > _activated_obj_del_cb : 0x454b5f90
07-13 10:45:21.986+0800 I/efl-extension(18415): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(687) > Surface is going to free in delete callback for image widget.
07-13 10:45:21.986+0800 I/efl-extension(18415): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(988) > surface 0x454a5e38 is freed
07-13 10:45:21.991+0800 I/efl-extension(18415): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-13 10:45:21.991+0800 I/efl-extension(18415): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x454988c0, elm_scroller, func : 0x43934351
07-13 10:45:21.991+0800 I/efl-extension(18415): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-13 10:45:21.991+0800 I/efl-extension(18415): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-13 10:45:21.991+0800 I/efl-extension(18415): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x454b5f90, elm_image, func : 0x43934351
07-13 10:45:21.991+0800 I/efl-extension(18415): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-13 10:45:21.991+0800 I/efl-extension(18415): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(852) > [0x454988c0 : elm_scroller] rotary callabck is deleted
07-13 10:45:22.256+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
07-13 10:45:22.261+0800 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18716
07-13 10:45:22.266+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 12
07-13 10:45:22.276+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
07-13 10:45:22.286+0800 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18716
07-13 10:45:22.371+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 12
07-13 10:45:22.431+0800 I/APP_CORE(18415): appcore-efl.c: __after_loop(1243) > [APP 18415] After terminate() callback
07-13 10:45:22.526+0800 E/EFL     (18716): ecore_x<18716> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=52406857 button=1
07-13 10:45:22.526+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d4910 : elm_genlist] mouse move
07-13 10:45:22.561+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d4910 : elm_genlist] mouse move
07-13 10:45:22.561+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437d4910 : elm_genlist] hold(0), freeze(0)
07-13 10:45:22.571+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d4910 : elm_genlist] mouse move
07-13 10:45:22.571+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437d4910 : elm_genlist] hold(0), freeze(0)
07-13 10:45:22.581+0800 E/EFL     (18716): ecore_x<18716> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=52406911 button=1
07-13 10:45:22.626+0800 I/AUL_PAD (18802): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-13 10:45:22.686+0800 I/MALI    (18415): egl_platform_x11.c: __egl_platform_terminate(324) > [EGL-X11] ################################################
07-13 10:45:22.686+0800 I/MALI    (18415): egl_platform_x11.c: __egl_platform_terminate(325) > [EGL-X11] PID=18415   close drm_fd=23 
07-13 10:45:22.686+0800 I/MALI    (18415): egl_platform_x11.c: __egl_platform_terminate(326) > [EGL-X11] ################################################
07-13 10:45:22.911+0800 E/EFL     (18716): elementary<18716> elm_layout.c:1021 _elm_layout_smart_content_set() could not swallow 0x4472dbf0 into part 'elm.swallow.content'
07-13 10:45:22.986+0800 E/EFL     (18716): edje<18716> edje_util.c:3785 edje_object_size_min_restricted_calc() group entry_layout has a non-fixed part 'entry_part'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-13 10:45:23.006+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4472f950 : elm_entry] mx(30), my(40), minx(0), miny(0), px(0), py(0)
07-13 10:45:23.006+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4472f950 : elm_entry] cw(30), ch(40), pw(0), ph(0)
07-13 10:45:23.021+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4472f950 : elm_entry] mx(4), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:45:23.021+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4472f950 : elm_entry] cw(4), ch(40), pw(0), ph(40)
07-13 10:45:23.021+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4472f950 : elm_entry] mx(4), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:45:23.021+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4472f950 : elm_entry] cw(4), ch(40), pw(0), ph(40)
07-13 10:45:23.021+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4472dbf0 : elm_scroller] mx(0), my(50), minx(0), miny(0), px(0), py(0)
07-13 10:45:23.021+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4472dbf0 : elm_scroller] cw(0), ch(50), pw(0), ph(0)
07-13 10:45:23.041+0800 E/EFL     (18716): elementary<18716> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-13 10:45:23.051+0800 E/EFL     (18716): elementary<18716> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44b7d960) will be pushed
07-13 10:45:23.051+0800 I/efl-extension(18716): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44b95a30]'s widget[0x44b7fe18] to layout widget[0x44b7d960]
07-13 10:45:23.051+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4472f950 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:45:23.051+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4472f950 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:45:23.056+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4472f950 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:45:23.056+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4472f950 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:45:23.056+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4472dbf0 : elm_scroller] mx(360), my(360), minx(0), miny(0), px(0), py(0)
07-13 10:45:23.056+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4472dbf0 : elm_scroller] cw(360), ch(360), pw(0), ph(0)
07-13 10:45:23.056+0800 I/efl-extension(18716): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-13 10:45:23.061+0800 E/EFL     (18716): edje<18716> edje_util.c:3785 edje_object_size_min_restricted_calc() group entry_layout has a non-fixed part 'entry_part'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-13 10:45:23.076+0800 E/EFL     (18716): elementary<18716> elc_naviframe.c:2796 _push_transition_cb() item(0x44b7d960) will transition
07-13 10:45:23.486+0800 E/EFL     (18716): elementary<18716> elc_naviframe.c:1193 _on_item_push_finished() item(0x437e5410) transition finished
07-13 10:45:23.486+0800 E/EFL     (18716): elementary<18716> elc_naviframe.c:1218 _on_item_show_finished() item(0x44b7d960) transition finished
07-13 10:45:23.501+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:45:23.501+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:45:23.501+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:45:23.506+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:45:23.506+0800 I/ISE_MULTI(  803): isemain.cpp: slot_set_return_key_disable(1252) > [0;36m[hidden state:true] disabled=0[0m
07-13 10:45:23.506+0800 E/TIZEN_N_SYSTEM_SETTINGS(  803): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
07-13 10:45:23.506+0800 E/TIZEN_N_SYSTEM_SETTINGS(  803): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
07-13 10:45:23.506+0800 E/TIZEN_N_SYSTEM_SETTINGS(  803): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
07-13 10:45:23.506+0800 E/TIZEN_N_SYSTEM_SETTINGS(  803): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
07-13 10:45:23.506+0800 W/ISF_PANEL_EFL(  734): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x1a00002 FAILED!
07-13 10:45:23.511+0800 W/ISF_PANEL_EFL(  734): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x1a00002 FAILED!
07-13 10:45:23.561+0800 I/ISE_MULTI(  803): isemain.cpp: slot_set_caps_mode(1113) > [0;36m[hidden state:true] mode=1[0m
07-13 10:45:23.586+0800 E/EFL     (  462): ecore_x<462> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x1a00002 time=52407841
07-13 10:45:23.591+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Generate_prediction_TH(1750) > [0;36mGen prediction[0m
07-13 10:45:23.626+0800 E/EFL     (18716): ecore_x<18716> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=52407841
07-13 10:45:23.626+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=52407841
07-13 10:45:23.666+0800 I/ISE_MULTI(  803): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff, fEnable[1],xt9Context.xt9OnOff[1],gFPredictionDisabled[0] [0m
07-13 10:45:23.666+0800 I/ISE_MULTI(  803): ise.cpp: ise_show(2316) > [0;36m--------BEFORE set is_candidate_on-----------[0m
07-13 10:45:23.666+0800 I/ISE_MULTI(  803): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff, fEnable[1],xt9Context.xt9OnOff[1],gFPredictionDisabled[0] [0m
07-13 10:45:23.666+0800 I/ISE_MULTI(  803): ise.cpp: relocate_main_window(335) > [0;36m----------START----------[0m
07-13 10:45:23.666+0800 I/ISE_MULTI(  803): ise.cpp: relocate_main_window(347) > [0;36m-------INPUT_MODE_HANDWRITING--------[0m
07-13 10:45:23.666+0800 E/ISE_MULTI(  803): ise-rotary-event-listener.cpp: rotary_input_init(119) > [0;31mrotary_input_init[0m
07-13 10:45:23.711+0800 I/ISE_MULTI(  803): ise.cpp: ise_show(2374) > [0;36m--------------------[0m
07-13 10:45:23.711+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(986) > [0;36m-----candidate_show-----[0m
07-13 10:45:23.711+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(1008) > [0;36mcandidate_show:is_chinese = 1[0m
07-13 10:45:23.711+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(1034) > [0;36m-----END-----[0m
07-13 10:45:23.786+0800 I/ISE_MULTI(  803): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff, fEnable[1],xt9Context.xt9OnOff[1],gFPredictionDisabled[0] [0m
07-13 10:45:23.791+0800 W/SWIFTKEY(  668): swiftkey_logger.cpp: reportError(44) > [0;33mSKLogger [ File Not Found : Could not read keypress model file at "/opt/usr/share/scim/swiftkey/lang/zh_CN/keyModel_qwerty_port.json" ][0m
07-13 10:45:23.791+0800 W/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Load_keymodel(2368) > [0;33mfail to set the keypress model to /opt/usr/share/scim/swiftkey/lang/zh_CN/keyModel_qwerty_port.json[0m
07-13 10:45:23.821+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_hide(1039) > [0;36mcandidate_hide[0m
07-13 10:45:23.941+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Generate_prediction_TH(1750) > [0;36mGen prediction[0m
07-13 10:45:24.231+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Generate_prediction_TH(1750) > [0;36mGen prediction[0m
07-13 10:45:24.241+0800 E/EFL     (18716): ecore_x<18716> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=52408388 button=1
07-13 10:45:24.241+0800 E/EFL     (18716): ecore_x<18716> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=52408452 button=1
07-13 10:45:24.241+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4472f950 : elm_entry] mouse move
07-13 10:45:24.241+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4472f950 : elm_entry] hold(0), freeze(0)
07-13 10:45:24.241+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4472f950 : elm_entry] mouse move
07-13 10:45:24.241+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4472f950 : elm_entry] hold(0), freeze(0)
07-13 10:45:24.241+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4472f950 : elm_entry] mouse move
07-13 10:45:24.241+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4472f950 : elm_entry] hold(0), freeze(0)
07-13 10:45:24.241+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4472f950 : elm_entry] mouse move
07-13 10:45:24.241+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4472f950 : elm_entry] hold(0), freeze(0)
07-13 10:45:24.271+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:45:24.271+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:45:24.291+0800 W/AUL_PAD ( 1314): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 18415 pgid = 18415
07-13 10:45:24.291+0800 W/AUL_PAD ( 1314): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
07-13 10:45:24.391+0800 W/AUL_PAD ( 1314): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-13 10:45:24.401+0800 I/AUL_AMD (  520): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 18415
07-13 10:45:24.401+0800 W/AUL     (  520): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(18415)
07-13 10:45:24.451+0800 W/STARTER (  741): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[803] goes to (3)
07-13 10:45:24.451+0800 E/AUL_AMD (  520): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 9
07-13 10:45:24.461+0800 I/MALI    (  803): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [280x300]
07-13 10:45:24.476+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:45:24.476+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:45:24.481+0800 E/ISE_MULTI(  803): ise-ui.cpp: indicator_popup_show_cb(1533) > [0;31mindicator_popup_show_cb[0m
07-13 10:45:24.596+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:45:24.596+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:45:24.606+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:45:24.606+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:45:24.706+0800 I/MALI    (  803): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x22]
07-13 10:45:24.711+0800 W/ISF_PANEL_EFL(  734): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x2800003 FAILED!
07-13 10:45:24.711+0800 W/ISF_PANEL_EFL(  734): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x2800003 FAILED!
07-13 10:45:24.761+0800 E/EFL     (18716): edje<18716> edje_util.c:3785 edje_object_size_min_restricted_calc() group entry_layout has a non-fixed part 'entry_part'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-13 10:45:24.761+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4472dbf0 : elm_scroller] mx(360), my(70), minx(0), miny(0), px(0), py(0)
07-13 10:45:24.761+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4472dbf0 : elm_scroller] cw(360), ch(70), pw(0), ph(0)
07-13 10:45:24.761+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4472f950 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:45:24.761+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4472f950 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:45:24.826+0800 I/ISE_MULTI(  803): isemain.cpp: slot_update_cursor_position(1172) > [0;36m[hidden state:false] pos=0[0m
07-13 10:45:24.826+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:45:24.831+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:45:24.841+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:45:24.841+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:45:24.851+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:45:24.851+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:45:24.856+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:45:24.856+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:45:24.861+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:45:24.861+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:45:24.866+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:45:24.866+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:45:24.871+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:45:24.876+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:45:24.886+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:45:24.886+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:45:24.896+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:45:24.896+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:45:24.896+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:45:24.896+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:45:24.901+0800 I/ISE_MULTI(  803): isemain.cpp: slot_reset_ise_input_context(1372) > [0;36m[hidden state:false][0m
07-13 10:45:25.006+0800 I/APP_CORE(  806): appcore-efl.c: __do_app(453) > [APP 806] Event: MEM_FLUSH State: PAUSED
07-13 10:45:25.286+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=52409613 button=1
07-13 10:45:25.381+0800 I/MALI    (  803): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [280x300] -> [360x360]
07-13 10:45:25.666+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=52409993 button=1
07-13 10:45:25.996+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __alarm_handler_idle(1484) > Lock the display not to enter LCD OFF
07-13 10:45:26.006+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-13 10:45:26.026+0800 W/AUL     (  516): app_signal.c: aul_update_freezer_status(456) > aul_update_freezer_status pid(499) type(wakeup)
07-13 10:45:26.036+0800 E/RESOURCED(  605): freezer-process.c: freezer_process_pid_set(150) > Cant find process info for 499
07-13 10:45:26.046+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __alarm_expired(1445) > alarm_id[2134521740] is expired.
07-13 10:45:26.046+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-13 10:45:26.046+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(2134521740)
07-13 10:45:26.046+0800 E/ALARM_MANAGER(  516): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(1591639436) is OVER.
07-13 10:45:26.046+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-13 10:45:26.046+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 13-7-2017, 03:59:08 (UTC).
07-13 10:45:26.046+0800 E/ALARM_MANAGER(  499): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.aweconn] : Alarm id [2134521740]
07-13 10:45:26.046+0800 W/WECONN  (  499): <__wc_device_try_to_connect_on_wear:171> { state=WC_FEATURE_STATE_ON, vendor=WC_DEVICE_OS_TYPE_ANDROID
07-13 10:45:26.046+0800 W/WECONN  (  499): <wc_manager_get_bearer_state:988> type : 1
07-13 10:45:26.046+0800 W/WECONN  (  499): <__wc_device_try_to_connect:677> connection=WC_CONNECTION_TYPE_BLUETOOTH_SPP_AUTOSWITCH, bearer=WC_BEARER_TYPE_BLUETOOTH
07-13 10:45:26.046+0800 W/WECONN  (  499): <__connect_for_auto_switch:1706> { device=0x42901dd8, device->bt_address=1E:F0
07-13 10:45:26.046+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-13 10:45:26.046+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-13 10:45:26.046+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __alarm_handler_idle(1510) > Unlock the display from LCD OFF
07-13 10:45:26.076+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-13 10:45:26.256+0800 W/WECONN  (  499): <__connect_for_auto_switch:1719> }
07-13 10:45:26.256+0800 W/WECONN  (  499):  ### Connect Request [WC_CONNECTION_TYPE_BLUETOOTH_SPP_AUTOSWITCH]
07-13 10:45:26.256+0800 W/WECONN  (  499): <__wc_device_try_to_connect_on_wear:185> }
07-13 10:45:26.771+0800 E/ISE_HWR (  803): handwriting.cpp: efl_ise_recog_timeout(213) > [0;31mEND[0m
07-13 10:45:26.811+0800 I/MALI    (  803): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [360x360] -> [280x300]
07-13 10:45:27.011+0800 E/EFL     (  462): ecore_x<462> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x2800081 time=52411167
07-13 10:45:27.011+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=52411167
07-13 10:45:27.116+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4472f950 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:45:27.116+0800 E/EFL     (18716): elementary<18716> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4472f950 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:45:27.146+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5480) > [0;36mSK_CMD_HWR_CANDIDATE_STRING[0m
07-13 10:45:27.146+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(0) = 1[0m
07-13 10:45:27.146+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(1) = x[0m
07-13 10:45:27.146+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(2) = t[0m
07-13 10:45:27.146+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(3) = y[0m
07-13 10:45:27.146+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(4) = g[0m
07-13 10:45:27.146+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5494) > [0;36mbefore update_lookup_table[0m
07-13 10:45:27.151+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:45:27.151+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:45:27.156+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 0[0m
07-13 10:45:27.501+0800 E/WMS     (  518): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-13 10:45:28.261+0800 E/EFL     (18716): ecore_x<18716> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=52412520 button=1
07-13 10:45:28.261+0800 E/EFL     (18716): ecore_x<18716> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=52412592 button=1
07-13 10:45:28.271+0800 I/ISE_MULTI(  803): isemain.cpp: slot_reset_ise_input_context(1372) > [0;36m[hidden state:false][0m
07-13 10:45:28.271+0800 E/ISE_HWR (  803): handwriting.cpp: __hwr_result_notification_callback(857) > [0;31m============iscommited == 1[0m
07-13 10:45:28.376+0800 W/CRASH_MANAGER(18766): worker.c: worker_job(1205) > 111871673656e149991392
