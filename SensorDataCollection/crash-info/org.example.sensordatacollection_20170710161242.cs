S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 9012
Date: 2017-07-10 16:12:42+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x414d0fbc
r2   = 0x414d0e40, r3   = 0x00000001
r4   = 0x00000000, r5   = 0x414c0acb
r6   = 0x414c0a97, r7   = 0xbebf5208
r8   = 0x4146f4f3, r9   = 0x00002334
r10  = 0x4004e7e8, fp   = 0x00000000
ip   = 0x404d9b50, sp   = 0xbebf4f38
lr   = 0x414c0903, pc   = 0x404d9b58
cpsr = 0x60000010

Memory Information
MemTotal:   491132 KB
MemFree:     11060 KB
Buffers:     13984 KB
Cached:     131872 KB
VmPeak:      73924 KB
VmSize:      73924 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14980 KB
VmRSS:       14980 KB
VmData:      14496 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22904 KB
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
414be000 414c1000 r-xp /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
414d4000 414d8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
414e1000 414e3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
414ec000 414f2000 r-xp /usr/lib/libappsvc.so.0.1.0
414fa000 4151e000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41527000 415f6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4160c000 41616000 r-xp /lib/libnss_files-2.13.so
418b2000 418bd000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
418c8000 418e9000 r-xp /usr/lib/libefl-extension.so.0.1.0
418f1000 41903000 r-xp /usr/lib/libefl-assist.so.0.1.0
4190b000 419c3000 r-xp /usr/lib/libcairo.so.2.11200.14
419ce000 419e4000 r-xp /usr/lib/libtts.so
419ed000 41a10000 r-xp /usr/lib/libui-extension.so.0.1.0
41a19000 41a24000 r-xp /usr/lib/libtbm.so.1.0.0
41a2c000 41a3a000 r-xp /usr/lib/libGLESv2.so.2.0
41a43000 41a44000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41a4d000 41a53000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a5b000 41a5e000 r-xp /usr/lib/libEGL.so.1.4
41a66000 41a6b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41a73000 41a76000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41a7e000 41a7f000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41a88000 41c10000 r-xp /usr/lib/libicui18n.so.57.1
41c20000 41d26000 r-xp /usr/lib/libicuuc.so.57.1
41d3c000 41d44000 r-xp /usr/lib/libdrm.so.2.4.0
41d4c000 41d4e000 r-xp /usr/lib/libdri2.so.0.0.0
41d56000 41d5c000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41d64000 41d69000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41d71000 41d8a000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
4362b000 4364c000 r-xp /usr/lib/libexif.so.12.3.3
4365f000 43661000 r-xp /usr/lib/libttrace.so.1.1
43669000 4366e000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43676000 4367c000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43685000 4368d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43695000 436b7000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
436c0000 436c7000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
436d0000 436d2000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
436da000 436e1000 r-xp /usr/lib/libminizip.so.1.0.0
436e9000 436f6000 r-xp /usr/lib/libail.so.0.1.0
436ff000 43705000 r-xp /usr/lib/libproc-stat.so.0.2.96
4370d000 4370e000 r-xp /usr/lib/libresponse.so.0.2.96
43716000 4371b000 r-xp /usr/lib/libsystem.so.0.0.0
43725000 437ef000 r-xp /usr/lib/libCOREGL.so.4.0
43b94000 43b9f000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43ba8000 43bad000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43bb5000 43bcc000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43bd9000 43bdb000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
444e3000 444e4000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
bebd5000 bebf6000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9012)
Call Stack Count: 11
 0: fclose + 0x8 (0x404d9b58) [/lib/libc.so.6] + 0x5cb58
 1: start_data_collection + 0xda (0x414c0903) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x2903
 2: create_base_gui + 0x152 (0x414bfcc7) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1cc7
 3: app_create + 0x12 (0x414bfabf) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1abf
 4: (0x414919c1) [/usr/lib/libcapi-appfw-application.so.0] + 0x19c1
 5: appcore_efl_main + 0x246 (0x40044a5b) [/usr/lib/libappcore-efl.so.1] + 0x3a5b
 6: ui_app_main + 0xb0 (0x41492421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 7: main + 0x116 (0x414bfa47) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1a47
 8: main + 0x122 (0x40001a53) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1a53
 9: __libc_start_main + 0x114 (0x4049485c) [/lib/libc.so.6] + 0x1785c
10: create_list_view + 0xf7 (0x40001e0c) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1e0c
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
 > (ret == 1) metadata(watchface) is empty.
07-10 16:12:33.550+0800 E/rpm-installer( 9002): installer-util.c: _installer_util_delete_dir(420) > (dp == NULL) opendir(/opt/usr/data/pkgmgr/org.example.sensordatacollection/) failed. [2][No such file or directory]
07-10 16:12:33.550+0800 E/rpm-installer( 9002): coretpk-installer.c: _coretpk_installer_install_package(3579) > Deletion failed: [/opt/usr/data/pkgmgr/org.example.sensordatacollection/]
07-10 16:12:33.595+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:33.595+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:33.640+0800 E/PKGMGR_OBSERVER( 9003): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[90030002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[start] val[install]
07-10 16:12:33.650+0800 E/APPS    (  824): pkgmgr.c: _start(495) >  (_exist_request_in_list(package)) -> _start() return
07-10 16:12:33.650+0800 E/APPS    (  824): pkgmgr.c: _pkgmgr_cb(840) >  pkgmgr_cbs[0].func has errors.
07-10 16:12:33.660+0800 W/AUL_AMD (  518): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(org.example.sensordatacollection), key(start), value(install)
07-10 16:12:33.670+0800 E/PKGMGR_OBSERVER( 9003): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[90030002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[install_percent] val[30]
07-10 16:12:33.695+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, STARTED]
07-10 16:12:33.720+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, PROCESSING]
07-10 16:12:33.795+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:33.795+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:33.820+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 16:12:33.820+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 16:12:33.820+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 16:12:33.820+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-10 16:12:33.820+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-10 16:12:33.820+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 16:12:33.820+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-10 16:12:33.820+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 16:12:33.820+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 16:12:33.820+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 16:12:33.820+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 16:12:33.820+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-10 16:12:33.820+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-10 16:12:33.820+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 16:12:33.820+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-10 16:12:33.820+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-10 16:12:33.820+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-10 16:12:33.820+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 16:12:33.820+0800 E/CAPI_APPFW_APP_CONTROL( 1013): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-10 16:12:33.820+0800 W/MUSIC_CONTROL_SERVICE( 1013): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1013]   [com.samsung.w-home]register msg port [true][0m
07-10 16:12:33.820+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 14
07-10 16:12:33.830+0800 W/AUL_AMD (  518): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 3159
07-10 16:12:33.830+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 14
07-10 16:12:33.835+0800 W/AUL_AMD (  518): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 824
07-10 16:12:33.845+0800 W/CERT_SVC( 9002): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
07-10 16:12:33.850+0800 W/MUSIC_CONTROL_SERVICE( 1013): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1013]   [MUSIC_PLAYER_EVENT][0m
07-10 16:12:33.850+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 16:12:33.850+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 16:12:33.850+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 16:12:33.850+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-10 16:12:33.850+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-10 16:12:33.850+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 16:12:33.850+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
07-10 16:12:33.850+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 16:12:33.850+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 16:12:33.850+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 16:12:33.850+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 16:12:33.850+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-10 16:12:33.850+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-10 16:12:33.850+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 16:12:33.850+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
07-10 16:12:33.850+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-10 16:12:33.850+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-10 16:12:33.850+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 16:12:33.850+0800 W/W_HOME  (  824): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
07-10 16:12:33.850+0800 E/W_HOME  (  824): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
07-10 16:12:33.855+0800 W/MUSIC_CONTROL_SERVICE( 1013): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1013]   [MUSIC_PLAYER_EVENT][0m
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 16:12:33.855+0800 W/W_HOME  (  824): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
07-10 16:12:33.855+0800 E/W_HOME  (  824): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-10 16:12:33.855+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 16:12:33.870+0800 E/rpm-installer( 9002): coretpk-parser.c: __coretpk_parser_verify_metadata(48) > (ret == 1) metadata is empty.
07-10 16:12:33.870+0800 E/rpm-installer( 9002): coretpk-parser.c: __coretpk_parser_append_path(417) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
07-10 16:12:33.870+0800 E/rpm-installer( 9002): coretpk-parser.c: __coretpk_parser_append_path(417) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
07-10 16:12:33.875+0800 E/rpm-installer( 9002): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(541) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
07-10 16:12:33.915+0800 E/PKGMGR_PARSER( 9002): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2167) > Manifest is Valid
07-10 16:12:33.920+0800 E/PKGMGR_PARSER( 9002): pkgmgr_parser.c: __parse_manifest_for_installation(1910) > parsing manifest for installation: /opt/share/packages/org.example.sensordatacollection.xml
07-10 16:12:33.920+0800 E/PKGMGR_PARSER( 9002): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
07-10 16:12:33.920+0800 E/PKGMGR_PARSER( 9002): pkgmgr_parser.c: __ps_process_tag(866) > tag is NULL
07-10 16:12:34.000+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:34.000+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:34.085+0800 I/efl-extension( 9002): efl_extension.c: eext_mod_init(40) > Init
07-10 16:12:34.085+0800 I/efl-extension( 9002): efl_extension.c: eext_mod_shutdown(46) > Shutdown
07-10 16:12:34.155+0800 E/PKGMGR_PARSER( 9002): pkgmgr_parser.c: __parse_manifest_for_installation(1952) > parsing manifest for installation Done
07-10 16:12:34.180+0800 E/PKGMGR_CERT( 9002): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
07-10 16:12:34.185+0800 E/PKGMGR_CERT( 9002): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 120
07-10 16:12:34.185+0800 E/PKGMGR_CERT( 9002): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 120
07-10 16:12:34.185+0800 E/PKGMGR_CERT( 9002): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 29 6
07-10 16:12:34.185+0800 E/PKGMGR_CERT( 9002): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 21 14
07-10 16:12:34.185+0800 E/PKGMGR_CERT( 9002): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 14
07-10 16:12:34.185+0800 E/PKGMGR_CERT( 9002): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 30 6
07-10 16:12:34.195+0800 E/PKGMGR_CERT( 9002): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(575) > Transaction Commit and End
07-10 16:12:34.195+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:34.195+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:34.205+0800 E/PKGMGR_OBSERVER( 9003): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[90030002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[install_percent] val[60]
07-10 16:12:34.265+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, PROCESSING]
07-10 16:12:34.290+0800 E/rpm-installer( 9002): installer-util.c: _installer_util_get_configuration_value(601) > [signature]=[on]
07-10 16:12:34.295+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-10 16:12:34.300+0800 E/rpm-installer( 9002): coretpk-installer.c: _coretpk_installer_apply_smack(3199) > groupid = [z0QlgvtZWc7MUAsAHX1kZCd6NyfN6kalPinZVqoqrqE=] for shared/trusted.
07-10 16:12:34.310+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 8707 pgid = 8707
07-10 16:12:34.310+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
07-10 16:12:34.350+0800 E/rpm-installer( 9002): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
07-10 16:12:34.370+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-10 16:12:34.375+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 8623 pgid = 8623
07-10 16:12:34.375+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
07-10 16:12:34.380+0800 I/AUL_AMD (  518): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8707
07-10 16:12:34.380+0800 W/AUL     (  518): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8707)
07-10 16:12:34.400+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:34.400+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:34.405+0800 E/PKGMGR_OBSERVER( 9003): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[90030002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[install_percent] val[100]
07-10 16:12:34.435+0800 E/rpm-installer( 9002): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
07-10 16:12:34.455+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, PROCESSING]
07-10 16:12:34.495+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-10 16:12:34.500+0800 I/AUL_AMD (  518): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8623
07-10 16:12:34.500+0800 W/AUL     (  518): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8623)
07-10 16:12:34.595+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:34.595+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:34.795+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:34.795+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:34.890+0800 I/AUL_AMD (  518): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8621
07-10 16:12:34.890+0800 W/AUL     (  518): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8621)
07-10 16:12:34.995+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:34.995+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:35.035+0800 E/PKGMGR_SERVER( 8998): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-10 16:12:35.195+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:35.195+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:35.395+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:35.395+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:35.595+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:35.595+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:35.795+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:35.795+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:35.995+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:35.995+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:36.110+0800 I/AUL_PAD ( 9012): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-10 16:12:36.195+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:36.200+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:36.375+0800 W/MM_CAMCORDER( 9014): mm_camcorder_internal.c: _mmcamcorder_constructor(203) >  start
07-10 16:12:36.375+0800 W/MM_CAMCORDER( 9014): mm_camcorder_internal.c: _mmcamcorder_constructor(213) >  done
07-10 16:12:36.380+0800 I/efl-extension( 9014): efl_extension.c: eext_mod_init(40) > Init
07-10 16:12:36.395+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:36.395+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:36.530+0800 I/efl-extension( 9013): efl_extension.c: eext_mod_init(40) > Init
07-10 16:12:36.595+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:36.595+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:36.605+0800 I/UXT     ( 9013): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-10 16:12:36.725+0800 I/AUL_PAD ( 9013): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-10 16:12:36.795+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:36.795+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:36.930+0800 E/PKGMGR_OBSERVER( 9003): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[90030002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[end] val[ok]
07-10 16:12:36.945+0800 W/W_HOME  (  824): clock_event.c: _pkgmgr_event_cb(247) > Pkg:org.example.sensordatacollection is updated, need to check validation
07-10 16:12:36.945+0800 W/W_HOME  (  824): clock_event.c: _pkgmgr_event_cb(251) > attacheck clock:com.samsung.watchface
07-10 16:12:36.980+0800 W/SVOICE  ( 3159): DomainAppState.cpp: operator()(64) > [0;32mINFO: Apps info changed. SetUploadSyncCondition[0;m
07-10 16:12:36.980+0800 W/SVOICE  ( 3159): PreferenceKey.cpp: SetUploadSyncCondition(551) > [0;32mINFO: UploadManager need to Sync : 1[0;m
07-10 16:12:36.990+0800 W/AUL_AMD (  518): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(org.example.sensordatacollection), key(end), value(ok)
07-10 16:12:36.995+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:36.995+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:37.025+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, COMPLETED]
07-10 16:12:37.025+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7081) > package install complete
07-10 16:12:37.025+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_package_install_event(5035) > 
07-10 16:12:37.025+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(2041) > Found in install_req_list?[0], index[-1]
07-10 16:12:37.025+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_package_install_event(5061) > triggered from Gear itself.
07-10 16:12:37.035+0800 E/PKGMGR_SERVER( 8998): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-10 16:12:37.090+0800 E/STARTER (  759): pkg-monitor.c: _pkg_monitor_get_metadata(136) > [_pkg_monitor_get_metadata:136] Failed to get metadata value[-2]
07-10 16:12:37.120+0800 E/WMS     (  516): wms_db.c: wms_db_package_event_insert_record(190) > 
07-10 16:12:37.130+0800 E/PKGMGR_INFO( 9003): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(1026) > callback is stopped.
07-10 16:12:37.140+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2887) > send_install_response completed : END
07-10 16:12:37.145+0800 E/PKGMGR_OBSERVER( 9003): pkg_observer.c: main(620) > OBSERVER end
07-10 16:12:37.155+0800 E/PKGMGR_SERVER( 8998): pkgmgr-server.c: sighandler(486) > child NORMAL exit [9003]
07-10 16:12:37.160+0800 E/PKGMGR_INFO(  513): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(922) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-10 16:12:37.190+0800 W/APPS    (  824): AppsViewNecklace.cpp: onTouchEventCancel(4949) >  touch cancel
07-10 16:12:37.195+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:37.195+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:37.395+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:37.395+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:37.450+0800 E/MALI    ( 9013): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-10 16:12:37.450+0800 E/MALI    ( 9013): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-10 16:12:37.450+0800 E/MALI    ( 9013): [gpu-ddk] devel/graphics_drv/r4p0
07-10 16:12:37.450+0800 E/MALI    ( 9013): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-10 16:12:37.450+0800 E/MALI    ( 9013): [coregl] devel/graphics_engine/master
07-10 16:12:37.450+0800 E/MALI    ( 9013): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-10 16:12:37.450+0800 E/MALI    ( 9013): 
07-10 16:12:37.595+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:37.595+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:37.795+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:37.795+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:37.995+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:37.995+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:38.120+0800 I/AUL     ( 9014): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 16:12:38.165+0800 I/AUL     ( 9014): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 16:12:38.165+0800 E/AUL     ( 9014): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 16:12:38.165+0800 E/AUL     ( 9014): aul_path.c: __get_path(169) > root_path is NULL!
07-10 16:12:38.185+0800 I/AUL     ( 9014): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 16:12:38.195+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:38.195+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:38.205+0800 I/AUL     ( 9014): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 16:12:38.205+0800 E/AUL     ( 9014): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 16:12:38.205+0800 E/AUL     ( 9014): aul_path.c: __get_path(169) > root_path is NULL!
07-10 16:12:38.265+0800 I/AUL     ( 9014): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 16:12:38.280+0800 I/AUL     ( 9014): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 16:12:38.280+0800 E/AUL     ( 9014): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 16:12:38.280+0800 E/AUL     ( 9014): aul_path.c: __get_path(169) > root_path is NULL!
07-10 16:12:38.290+0800 I/AUL     ( 9014): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 16:12:38.300+0800 I/AUL     ( 9014): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 16:12:38.300+0800 E/AUL     ( 9014): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 16:12:38.300+0800 E/AUL     ( 9014): aul_path.c: __get_path(169) > root_path is NULL!
07-10 16:12:38.310+0800 I/AUL     ( 9014): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 16:12:38.320+0800 I/AUL     ( 9014): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 16:12:38.320+0800 E/AUL     ( 9014): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 16:12:38.320+0800 E/AUL     ( 9014): aul_path.c: __get_path(169) > root_path is NULL!
07-10 16:12:38.335+0800 I/AUL     ( 9014): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 16:12:38.345+0800 I/AUL     ( 9014): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 16:12:38.345+0800 E/AUL     ( 9014): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 16:12:38.345+0800 E/AUL     ( 9014): aul_path.c: __get_path(169) > root_path is NULL!
07-10 16:12:38.355+0800 I/AUL     ( 9014): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 16:12:38.365+0800 I/AUL     ( 9014): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 16:12:38.370+0800 E/AUL     ( 9014): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 16:12:38.370+0800 E/AUL     ( 9014): aul_path.c: __get_path(169) > root_path is NULL!
07-10 16:12:38.380+0800 I/AUL     ( 9014): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 16:12:38.390+0800 I/AUL     ( 9014): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 16:12:38.390+0800 E/AUL     ( 9014): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 16:12:38.390+0800 E/AUL     ( 9014): aul_path.c: __get_path(169) > root_path is NULL!
07-10 16:12:38.395+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:38.395+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:38.420+0800 I/UXT     ( 9014): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-10 16:12:38.565+0800 E/MALI    ( 9014): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-10 16:12:38.565+0800 E/MALI    ( 9014): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-10 16:12:38.565+0800 E/MALI    ( 9014): [gpu-ddk] devel/graphics_drv/r4p0
07-10 16:12:38.565+0800 E/MALI    ( 9014): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-10 16:12:38.565+0800 E/MALI    ( 9014): [coregl] devel/graphics_engine/master
07-10 16:12:38.565+0800 E/MALI    ( 9014): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-10 16:12:38.595+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:38.595+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:38.795+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:38.795+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:38.995+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:38.995+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:39.035+0800 E/PKGMGR_SERVER( 8998): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-10 16:12:39.195+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:39.195+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:39.235+0800 E/rpm-installer( 9002): rpm-appcore-intf.c: main(273) > ------------------------------------------------
07-10 16:12:39.235+0800 E/rpm-installer( 9002): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
07-10 16:12:39.235+0800 E/rpm-installer( 9002): rpm-appcore-intf.c: main(275) > ------------------------------------------------
07-10 16:12:39.255+0800 E/PKGMGR_SERVER( 8998): pkgmgr-server.c: sighandler(486) > child NORMAL exit [9002]
07-10 16:12:39.330+0800 E/RESOURCED(  635): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/9002/oom_score_adj failed
07-10 16:12:39.330+0800 E/RESOURCED(  635): proc-main.c: resourced_proc_status_change(1508) > Empty pid or process not exists. 9002
07-10 16:12:39.395+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:39.395+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:39.525+0800 I/MALI    ( 9014): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x360]
07-10 16:12:39.530+0800 E/MALI    ( 9014): egl_mali.c: __egl_mali_post_to_window_surface(1183) > MALI_ERR_EARLY_OUT - Don't need to add frame callback because frame is unmodified
07-10 16:12:39.540+0800 I/AUL     ( 9023): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
07-10 16:12:39.550+0800 I/AUL     ( 9023): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 16:12:39.550+0800 E/AUL     ( 9023): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 16:12:39.550+0800 E/AUL     ( 9023): aul_path.c: __get_path(169) > root_path is NULL!
07-10 16:12:39.600+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:39.600+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:39.760+0800 W/WATCH_CORE(  904): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 2
07-10 16:12:39.760+0800 I/WATCH_CORE(  904): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
07-10 16:12:39.760+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:39.760+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:39.765+0800 E/wnoti-service( 1050): wnoti-db-utility.c: context_wearonoff_status_cb(1774) > status changed from 2 to 1 
07-10 16:12:39.765+0800 E/wnoti-service( 1050): wnoti-native-client.c: handle_cache_notification(737) > >>
07-10 16:12:39.765+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23423) > wear_monitor_status update[0] = 2 -> 1
07-10 16:12:39.770+0800 W/WECONN  (  499): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_ON
07-10 16:12:39.770+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:354> { state=WC_FEATURE_STATE_ON
07-10 16:12:39.770+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:369> Disconnected manually : 0
07-10 16:12:39.775+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:370> Disconnected by auto switch : 0
07-10 16:12:39.775+0800 W/WECONN  (  499): <wc_manager_get_bearer_state:988> type : 1
07-10 16:12:39.805+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:39.805+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:39.840+0800 E/ALARM_MANAGER(  499): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(5), start(10-7-2017, 16:12:45), repeat(0), interval(0), type(-1073741822)
07-10 16:12:39.865+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [499].
07-10 16:12:39.885+0800 W/SHealthService( 1110): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
07-10 16:12:39.910+0800 I/AUL     (  511): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-10 16:12:39.915+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 15
07-10 16:12:39.935+0800 I/AUL_AMD (  518): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-10 16:12:39.955+0800 I/AUL_AMD (  518): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-10 16:12:39.955+0800 E/ALARM_MANAGER(  511): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1499674365, Mon Jul 10 16:12:45 2017
07-10 16:12:39.955+0800 E/ALARM_MANAGER(  511): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 423097521, next duetime: 1499674365
07-10 16:12:39.955+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(423097521)
07-10 16:12:39.955+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1499680748), due_time(1499674365)
07-10 16:12:39.965+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-10 16:12:39.965+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-10 16:12:39.965+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 10-7-2017, 08:12:45 (UTC).
07-10 16:12:39.965+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-10 16:12:39.965+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-10 16:12:39.975+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-10 16:12:39.975+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-10 16:12:39.985+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:385> }
07-10 16:12:39.985+0800 W/WECONN  (  499): <__wc_feature_wearonoff_monitor_cb:531> }
07-10 16:12:39.995+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:39.995+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:40.200+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:40.200+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:40.400+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:40.400+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:40.600+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:40.600+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:40.800+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:40.800+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:41.000+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:41.000+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:41.035+0800 E/PKGMGR_SERVER( 8998): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
07-10 16:12:41.035+0800 E/PKGMGR_SERVER( 8998): pkgmgr-server.c: main(2296) > package manager server terminated.
07-10 16:12:41.205+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:41.205+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:41.400+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:41.400+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:41.605+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:41.605+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:41.795+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:41.795+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:42.000+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:42.000+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:42.200+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:42.200+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:42.385+0800 W/AUL     ( 9084): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-10 16:12:42.390+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 0
07-10 16:12:42.405+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:42.405+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:42.410+0800 I/AUL_AMD (  518): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
07-10 16:12:42.425+0800 I/AUL_AMD (  518): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
07-10 16:12:42.425+0800 E/AUL_AMD (  518): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
07-10 16:12:42.425+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(1782) > caller pid : 9084
07-10 16:12:42.440+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(2218) > pad pid(-5)
07-10 16:12:42.445+0800 W/AUL_PAD ( 1342): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-10 16:12:42.445+0800 W/AUL_PAD ( 1342): launchpad.c: __send_result_to_caller(272) > Check app launching
07-10 16:12:42.445+0800 E/RESOURCED(  635): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 3
07-10 16:12:42.445+0800 W/AUL_PAD ( 9012): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-10 16:12:42.450+0800 W/AUL_PAD ( 9012): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-10 16:12:42.450+0800 W/AUL_PAD ( 9012): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-10 16:12:42.450+0800 W/AUL_PAD ( 9012): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-10 16:12:42.525+0800 I/efl-extension( 9012): efl_extension.c: eext_mod_init(40) > Init
07-10 16:12:42.530+0800 I/UXT     ( 9012): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-10 16:12:42.530+0800 W/AUL_PAD ( 9012): launchpad_loader.c: main(690) > [candidate] dlsym
07-10 16:12:42.530+0800 W/AUL_PAD ( 9012): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-10 16:12:42.535+0800 I/CAPI_APPFW_APPLICATION( 9012): app_main.c: ui_app_main(704) > app_efl_main
07-10 16:12:42.540+0800 I/CAPI_APPFW_APPLICATION( 9012): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-10 16:12:42.545+0800 W/AUL     (  518): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(9012) type(uiapp) bg(0)
07-10 16:12:42.545+0800 W/AUL_AMD (  518): amd_status.c: __socket_monitor_cb(1277) > (9012) was created
07-10 16:12:42.545+0800 W/AUL     ( 9084): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9012)
07-10 16:12:42.595+0800 W/STARTER (  759): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [9012]
07-10 16:12:42.600+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:42.600+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:42.780+0800 I/efl-extension( 9012): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-10 16:12:42.780+0800 I/efl-extension( 9012): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-10 16:12:42.780+0800 I/efl-extension( 9012): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-10 16:12:42.785+0800 I/efl-extension( 9012): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-10 16:12:42.785+0800 I/efl-extension( 9012): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x445111b0, elm_image, _activated_obj : 0x0, activated : 1
07-10 16:12:42.785+0800 E/EFL     ( 9012): elementary<9012> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-10 16:12:42.790+0800 E/EFL     ( 9012): elementary<9012> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44511618) will be pushed
07-10 16:12:42.790+0800 I/efl-extension( 9012): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x418963e0]'s widget[0x44512aa8] to layout widget[0x44511618]
07-10 16:12:42.795+0800 E/EFL     ( 9012): elementary<9012> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e7d58 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-10 16:12:42.795+0800 E/EFL     ( 9012): elementary<9012> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e7d58 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-10 16:12:42.795+0800 I/efl-extension( 9012): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-10 16:12:42.795+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:42.795+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:42.995+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:42.995+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:43.195+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:43.195+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:43.225+0800 W/CRASH_MANAGER( 9086): worker.c: worker_job(1205) > 110901273656e149967436
