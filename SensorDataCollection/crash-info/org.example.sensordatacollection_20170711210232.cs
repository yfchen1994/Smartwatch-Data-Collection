S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 7201
Date: 2017-07-11 21:02:32+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 7201, uid 5000)

Register Information
r0   = 0x00000002, r1   = 0x00000000
r2   = 0x44db93d8, r3   = 0x00000000
r4   = 0x00000022, r5   = 0x00000001
r6   = 0x44db93d8, r7   = 0x4138db70
r8   = 0x00000002, r9   = 0x40458824
r10  = 0x414c13fc, fp   = 0xbeb8bcfc
ip   = 0x00000000, sp   = 0xbeb896b8
lr   = 0x404bfe88, pc   = 0x404bfd40
cpsr = 0x40000010

Memory Information
MemTotal:   491132 KB
MemFree:      5992 KB
Buffers:     32068 KB
Cached:     159588 KB
VmPeak:     109488 KB
VmSize:     107960 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23888 KB
VmRSS:       23888 KB
VmData:      44424 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25416 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 7201 TID = 7201
7201 7314 7330 7331 7332 

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
418c8000 418cd000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
418d5000 418e1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
418ea000 4190b000 r-xp /usr/lib/libefl-extension.so.0.1.0
41913000 41918000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41920000 4194a000 r-xp /usr/lib/libsensor.so.1.9.5
41953000 4195a000 r-xp /usr/lib/libctx-shared.so.0.8.3
41962000 41967000 r-xp /usr/lib/libctx-client.so.0.8.3
4196f000 41981000 r-xp /usr/lib/libefl-assist.so.0.1.0
41989000 41a41000 r-xp /usr/lib/libcairo.so.2.11200.14
41a4c000 41a56000 r-xp /usr/lib/libsensord-shared.so
41a5e000 41a6d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
41a76000 41a8c000 r-xp /usr/lib/libtts.so
41a95000 41ab8000 r-xp /usr/lib/libui-extension.so.0.1.0
41ac1000 41acc000 r-xp /usr/lib/libtbm.so.1.0.0
41ad4000 41ae2000 r-xp /usr/lib/libGLESv2.so.2.0
41aeb000 41aec000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41af5000 41afb000 r-xp /usr/lib/libxcb-render.so.0.0.0
41b03000 41b06000 r-xp /usr/lib/libEGL.so.1.4
41b0e000 41b11000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41b19000 41b1a000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41b23000 41cab000 r-xp /usr/lib/libicui18n.so.57.1
41cbb000 41dc1000 r-xp /usr/lib/libicuuc.so.57.1
41dd7000 41ddf000 r-xp /usr/lib/libdrm.so.2.4.0
41de7000 41de9000 r-xp /usr/lib/libdri2.so.0.0.0
41df1000 41df7000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41dff000 41e04000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41e0c000 41e25000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
436c6000 436e7000 r-xp /usr/lib/libexif.so.12.3.3
436fa000 436fc000 r-xp /usr/lib/libttrace.so.1.1
43704000 43709000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43711000 43717000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43720000 43728000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43730000 43752000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4375b000 43762000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4376b000 4376d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43775000 4377c000 r-xp /usr/lib/libminizip.so.1.0.0
43784000 43791000 r-xp /usr/lib/libail.so.0.1.0
4379a000 437a0000 r-xp /usr/lib/libproc-stat.so.0.2.96
437a8000 437a9000 r-xp /usr/lib/libresponse.so.0.2.96
437b1000 437b6000 r-xp /usr/lib/libsystem.so.0.0.0
437c0000 4388a000 r-xp /usr/lib/libCOREGL.so.4.0
43c2f000 43c3a000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c43000 43c48000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43c50000 43c67000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43c74000 43c76000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43c7f000 444fd000 rw-p [stack:7314]
44600000 44601000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
44a28000 44a29000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44a47000 44a4f000 r-xp /usr/lib/libfeedback.so.0.1.4
44a51000 44a52000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44a5a000 44a5c000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
44a64000 44a6f000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
44a77000 44a7e000 r-xp /usr/lib/libmmfcommon.so.0.0.0
44a86000 44a9e000 r-xp /usr/lib/libmmfsound.so.0.1.0
44aaf000 44ab3000 r-xp /usr/lib/libmmfsession.so.0.0.0
44abc000 44ac7000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
44ad4000 44ad8000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
44ae0000 44af6000 r-xp /usr/lib/libavsysaudio.so.0.0.1
44afe000 44b5f000 r-xp /usr/lib/libasound.so.2.0.0
44b69000 44b6c000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44b74000 44bac000 r-xp /usr/lib/libpulse.so.0.16.2
44bad000 44bb0000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
44bb8000 44c00000 r-xp /usr/lib/libmdm.so.1.2.62
44c01000 44c04000 r-xp /usr/lib/libtinycompress.so.0.0.0
44c0c000 44c11000 r-xp /usr/lib/libjson.so.0.0.1
44c19000 44c62000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
44c6b000 44cb2000 r-xp /usr/lib/libsndfile.so.1.0.26
44cbe000 44ccd000 r-xp /usr/lib/libmdm-common.so.1.1.22
44cd6000 44cf8000 r-xp /usr/lib/libvorbis.so.0.4.3
44d00000 44d04000 r-xp /usr/lib/libogg.so.0.7.1
4500d000 4580c000 rw-p [stack:7330]
4580d000 4600c000 rw-p [stack:7331]
4600d000 46900000 rw-p [stack:7332]
beb6c000 beb8d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7201)
Call Stack Count: 1
 0: (0x404bfd40) [/lib/libc.so.6] + 0x42d40
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
ation']//*[name()='support-size']/@preview)
07-11 21:01:59.355+0800 E/rpm-installer( 7190): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(541) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
07-11 21:01:59.445+0800 E/PKGMGR_PARSER( 7190): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2167) > Manifest is Valid
07-11 21:01:59.450+0800 E/PKGMGR_PARSER( 7190): pkgmgr_parser.c: __parse_manifest_for_installation(1910) > parsing manifest for installation: /opt/share/packages/org.example.sensordatacollection.xml
07-11 21:01:59.455+0800 E/PKGMGR_PARSER( 7190): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
07-11 21:01:59.455+0800 E/PKGMGR_PARSER( 7190): pkgmgr_parser.c: __ps_process_tag(866) > tag is NULL
07-11 21:01:59.540+0800 I/PRIVACY-MANAGER-CLIENT( 7190): SocketClient.cpp: SocketClient(37) > Client created
07-11 21:01:59.650+0800 I/efl-extension( 7190): efl_extension.c: eext_mod_init(40) > Init
07-11 21:01:59.650+0800 I/efl-extension( 7190): efl_extension.c: eext_mod_shutdown(46) > Shutdown
07-11 21:01:59.740+0800 E/PKGMGR_PARSER( 7190): pkgmgr_parser.c: __parse_manifest_for_installation(1952) > parsing manifest for installation Done
07-11 21:01:59.775+0800 E/PKGMGR_CERT( 7190): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
07-11 21:01:59.775+0800 E/PKGMGR_CERT( 7190): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 120
07-11 21:01:59.780+0800 E/PKGMGR_CERT( 7190): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 120
07-11 21:01:59.780+0800 E/PKGMGR_CERT( 7190): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 29 6
07-11 21:01:59.780+0800 E/PKGMGR_CERT( 7190): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 21 14
07-11 21:01:59.780+0800 E/PKGMGR_CERT( 7190): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 14
07-11 21:01:59.780+0800 E/PKGMGR_CERT( 7190): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 30 6
07-11 21:01:59.790+0800 E/PKGMGR_CERT( 7190): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(575) > Transaction Commit and End
07-11 21:01:59.800+0800 E/PKGMGR_OBSERVER( 7191): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[71910002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[install_percent] val[60]
07-11 21:01:59.845+0800 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, PROCESSING]
07-11 21:01:59.865+0800 E/rpm-installer( 7190): installer-util.c: _installer_util_get_configuration_value(601) > [signature]=[on]
07-11 21:01:59.875+0800 E/rpm-installer( 7190): coretpk-installer.c: _coretpk_installer_apply_smack(3199) > groupid = [z0QlgvtZWc7MUAsAHX1kZCd6NyfN6kalPinZVqoqrqE=] for shared/trusted.
07-11 21:01:59.915+0800 E/rpm-installer( 7190): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
07-11 21:01:59.920+0800 E/PKGMGR_OBSERVER( 7191): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[71910002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[install_percent] val[100]
07-11 21:01:59.930+0800 W/AUL_PAD ( 1295): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 6748 pgid = 6748
07-11 21:01:59.930+0800 W/AUL_PAD ( 1295): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
07-11 21:01:59.975+0800 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, PROCESSING]
07-11 21:01:59.975+0800 E/rpm-installer( 7190): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
07-11 21:02:00.055+0800 I/AUL_AMD (  522): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6748
07-11 21:02:00.055+0800 W/AUL     (  522): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6748)
07-11 21:02:00.125+0800 W/AUL_PAD ( 1295): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-11 21:02:00.125+0800 W/AUL_PAD ( 1295): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 6652 pgid = -1
07-11 21:02:00.125+0800 W/AUL_PAD ( 1295): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
07-11 21:02:00.125+0800 W/AUL_PAD ( 1295): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-11 21:02:00.130+0800 I/AUL_AMD (  522): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6652
07-11 21:02:00.130+0800 W/AUL     (  522): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6652)
07-11 21:02:00.305+0800 I/AUL_AMD (  522): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6650
07-11 21:02:00.305+0800 W/AUL     (  522): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6650)
07-11 21:02:00.860+0800 W/SHealthService( 1108): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-11 21:02:00.875+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1108): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
07-11 21:02:00.875+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1108): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
07-11 21:02:00.880+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1108): preference.c: preference_get_double(1214) > preference_get_double(1108) : pedometer_inactive_period error
07-11 21:02:00.880+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1108): preference.c: _preference_check_retry_err(507) > key(inactive_test_mode_on), check retry err: -21/(2/No such file or directory).
07-11 21:02:00.880+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1108): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_test_mode_on) step(-17825744) failed(2 / No such file or directory)
07-11 21:02:00.880+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1108): preference.c: preference_get_boolean(1173) > preference_get_boolean(1108) : inactive_test_mode_on error
07-11 21:02:00.880+0800 W/SHealthService( 1108): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-11 21:02:00.905+0800 W/SHealthService( 1108): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-11 21:02:01.030+0800 E/PKGMGR_SERVER( 7189): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-11 21:02:01.415+0800 I/AUL_PAD ( 7201): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-11 21:02:01.785+0800 W/MM_CAMCORDER( 7203): mm_camcorder_internal.c: _mmcamcorder_constructor(203) >  start
07-11 21:02:01.785+0800 W/MM_CAMCORDER( 7203): mm_camcorder_internal.c: _mmcamcorder_constructor(213) >  done
07-11 21:02:01.795+0800 I/efl-extension( 7203): efl_extension.c: eext_mod_init(40) > Init
07-11 21:02:01.950+0800 I/efl-extension( 7202): efl_extension.c: eext_mod_init(40) > Init
07-11 21:02:02.180+0800 I/UXT     ( 7202): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-11 21:02:02.195+0800 E/PKGMGR_OBSERVER( 7191): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[71910002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[end] val[ok]
07-11 21:02:02.205+0800 W/W_HOME  (  807): clock_event.c: _pkgmgr_event_cb(247) > Pkg:org.example.sensordatacollection is updated, need to check validation
07-11 21:02:02.205+0800 W/W_HOME  (  807): clock_event.c: _pkgmgr_event_cb(251) > attacheck clock:com.samsung.watchface
07-11 21:02:02.235+0800 W/AUL_AMD (  522): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(org.example.sensordatacollection), key(end), value(ok)
07-11 21:02:02.280+0800 E/STARTER (  754): pkg-monitor.c: _pkg_monitor_get_metadata(136) > [_pkg_monitor_get_metadata:136] Failed to get metadata value[-2]
07-11 21:02:02.305+0800 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, COMPLETED]
07-11 21:02:02.305+0800 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7081) > package install complete
07-11 21:02:02.305+0800 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_package_install_event(5035) > 
07-11 21:02:02.305+0800 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(2041) > Found in install_req_list?[0], index[-1]
07-11 21:02:02.305+0800 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_package_install_event(5061) > triggered from Gear itself.
07-11 21:02:02.355+0800 E/WMS     (  519): wms_db.c: wms_db_package_event_insert_record(190) > 
07-11 21:02:02.355+0800 E/PKGMGR_INFO( 7191): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(1026) > callback is stopped.
07-11 21:02:02.370+0800 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2887) > send_install_response completed : END
07-11 21:02:02.385+0800 E/PKGMGR_INFO(  518): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(922) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-11 21:02:02.390+0800 E/PKGMGR_OBSERVER( 7191): pkg_observer.c: main(620) > OBSERVER end
07-11 21:02:02.400+0800 W/APPS    (  807): AppsViewNecklace.cpp: onTouchEventCancel(4949) >  touch cancel
07-11 21:02:02.405+0800 E/PKGMGR_SERVER( 7189): pkgmgr-server.c: sighandler(486) > child NORMAL exit [7191]
07-11 21:02:02.485+0800 I/AUL_PAD ( 7202): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-11 21:02:02.515+0800 E/MALI    ( 7202): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-11 21:02:02.520+0800 E/MALI    ( 7202): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-11 21:02:02.520+0800 E/MALI    ( 7202): [gpu-ddk] devel/graphics_drv/r4p0
07-11 21:02:02.520+0800 E/MALI    ( 7202): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-11 21:02:02.520+0800 E/MALI    ( 7202): [coregl] devel/graphics_engine/master
07-11 21:02:02.520+0800 E/MALI    ( 7202): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-11 21:02:02.520+0800 E/MALI    ( 7202): 
07-11 21:02:03.030+0800 E/PKGMGR_SERVER( 7189): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-11 21:02:03.255+0800 I/AUL     ( 7203): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 21:02:03.280+0800 I/AUL     ( 7203): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 21:02:03.280+0800 E/AUL     ( 7203): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-11 21:02:03.285+0800 E/AUL     ( 7203): aul_path.c: __get_path(169) > root_path is NULL!
07-11 21:02:03.305+0800 I/AUL     ( 7203): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 21:02:03.325+0800 I/AUL     ( 7203): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 21:02:03.330+0800 E/AUL     ( 7203): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-11 21:02:03.335+0800 E/AUL     ( 7203): aul_path.c: __get_path(169) > root_path is NULL!
07-11 21:02:03.355+0800 I/AUL     ( 7203): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 21:02:03.375+0800 I/AUL     ( 7203): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 21:02:03.380+0800 E/AUL     ( 7203): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-11 21:02:03.380+0800 E/AUL     ( 7203): aul_path.c: __get_path(169) > root_path is NULL!
07-11 21:02:03.390+0800 I/AUL     ( 7203): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 21:02:03.400+0800 I/AUL     ( 7203): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 21:02:03.400+0800 E/AUL     ( 7203): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-11 21:02:03.400+0800 E/AUL     ( 7203): aul_path.c: __get_path(169) > root_path is NULL!
07-11 21:02:03.415+0800 I/AUL     ( 7203): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 21:02:03.425+0800 I/AUL     ( 7203): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 21:02:03.425+0800 E/AUL     ( 7203): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-11 21:02:03.425+0800 E/AUL     ( 7203): aul_path.c: __get_path(169) > root_path is NULL!
07-11 21:02:03.435+0800 I/AUL     ( 7203): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 21:02:03.445+0800 I/AUL     ( 7203): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 21:02:03.445+0800 E/AUL     ( 7203): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-11 21:02:03.450+0800 E/AUL     ( 7203): aul_path.c: __get_path(169) > root_path is NULL!
07-11 21:02:03.460+0800 I/AUL     ( 7203): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 21:02:03.475+0800 I/AUL     ( 7203): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 21:02:03.475+0800 E/AUL     ( 7203): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-11 21:02:03.475+0800 E/AUL     ( 7203): aul_path.c: __get_path(169) > root_path is NULL!
07-11 21:02:03.485+0800 I/AUL     ( 7203): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 21:02:03.495+0800 I/AUL     ( 7203): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 21:02:03.495+0800 E/AUL     ( 7203): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-11 21:02:03.495+0800 E/AUL     ( 7203): aul_path.c: __get_path(169) > root_path is NULL!
07-11 21:02:03.525+0800 I/UXT     ( 7203): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-11 21:02:03.655+0800 E/MALI    ( 7203): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-11 21:02:03.655+0800 E/MALI    ( 7203): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-11 21:02:03.655+0800 E/MALI    ( 7203): [gpu-ddk] devel/graphics_drv/r4p0
07-11 21:02:03.655+0800 E/MALI    ( 7203): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-11 21:02:03.655+0800 E/MALI    ( 7203): [coregl] devel/graphics_engine/master
07-11 21:02:03.655+0800 E/MALI    ( 7203): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-11 21:02:03.655+0800 E/MALI    ( 7203): HK
07-11 21:02:04.480+0800 I/MALI    ( 7203): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x360]
07-11 21:02:04.480+0800 E/MALI    ( 7203): egl_mali.c: __egl_mali_post_to_window_surface(1183) > MALI_ERR_EARLY_OUT - Don't need to add frame callback because frame is unmodified
07-11 21:02:04.490+0800 I/AUL     ( 7212): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
07-11 21:02:04.505+0800 I/AUL     ( 7212): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 21:02:04.505+0800 E/AUL     ( 7212): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-11 21:02:04.505+0800 E/AUL     ( 7212): aul_path.c: __get_path(169) > root_path is NULL!
07-11 21:02:04.510+0800 E/rpm-installer( 7190): rpm-appcore-intf.c: main(273) > ------------------------------------------------
07-11 21:02:04.510+0800 E/rpm-installer( 7190): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
07-11 21:02:04.510+0800 E/rpm-installer( 7190): rpm-appcore-intf.c: main(275) > ------------------------------------------------
07-11 21:02:04.545+0800 E/PKGMGR_SERVER( 7189): pkgmgr-server.c: sighandler(486) > child NORMAL exit [7190]
07-11 21:02:05.030+0800 E/PKGMGR_SERVER( 7189): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
07-11 21:02:05.030+0800 E/PKGMGR_SERVER( 7189): pkgmgr-server.c: main(2296) > package manager server terminated.
07-11 21:02:12.445+0800 W/AUL     ( 7294): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-11 21:02:12.450+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 0
07-11 21:02:12.480+0800 I/AUL_AMD (  522): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
07-11 21:02:12.505+0800 I/AUL_AMD (  522): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
07-11 21:02:12.505+0800 E/AUL_AMD (  522): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
07-11 21:02:12.505+0800 W/AUL_AMD (  522): amd_launch.c: _start_app(1782) > caller pid : 7294
07-11 21:02:12.530+0800 E/RESOURCED(  630): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 1
07-11 21:02:12.535+0800 W/AUL_AMD (  522): amd_launch.c: _start_app(2218) > pad pid(-5)
07-11 21:02:12.535+0800 W/AUL_PAD ( 1295): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-11 21:02:12.535+0800 W/AUL_PAD ( 1295): launchpad.c: __send_result_to_caller(272) > Check app launching
07-11 21:02:12.535+0800 W/AUL_PAD ( 7201): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-11 21:02:12.540+0800 W/AUL_PAD ( 7201): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-11 21:02:12.540+0800 W/AUL_PAD ( 7201): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-11 21:02:12.540+0800 W/AUL_PAD ( 7201): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-11 21:02:12.620+0800 I/efl-extension( 7201): efl_extension.c: eext_mod_init(40) > Init
07-11 21:02:12.625+0800 I/UXT     ( 7201): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-11 21:02:12.640+0800 W/AUL_PAD ( 7201): launchpad_loader.c: main(690) > [candidate] dlsym
07-11 21:02:12.640+0800 W/AUL_PAD ( 7201): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-11 21:02:12.645+0800 I/CAPI_APPFW_APPLICATION( 7201): app_main.c: ui_app_main(704) > app_efl_main
07-11 21:02:12.650+0800 I/CAPI_APPFW_APPLICATION( 7201): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-11 21:02:12.735+0800 W/AUL     (  522): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(7201) type(uiapp) bg(0)
07-11 21:02:12.735+0800 W/AUL_AMD (  522): amd_status.c: __socket_monitor_cb(1277) > (7201) was created
07-11 21:02:12.740+0800 W/AUL     ( 7294): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7201)
07-11 21:02:12.745+0800 W/STARTER (  754): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7201]
07-11 21:02:12.840+0800 I/efl-extension( 7201): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-11 21:02:12.840+0800 I/efl-extension( 7201): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-11 21:02:12.840+0800 I/efl-extension( 7201): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-11 21:02:12.840+0800 I/efl-extension( 7201): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-11 21:02:12.845+0800 I/efl-extension( 7201): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44509920, elm_image, _activated_obj : 0x0, activated : 1
07-11 21:02:12.845+0800 E/EFL     ( 7201): elementary<7201> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-11 21:02:12.855+0800 E/EFL     ( 7201): elementary<7201> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44509d88) will be pushed
07-11 21:02:12.855+0800 I/efl-extension( 7201): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x41826fe8]'s widget[0x4450b218] to layout widget[0x44509d88]
07-11 21:02:12.855+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e9728 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-11 21:02:12.855+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e9728 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-11 21:02:12.860+0800 I/efl-extension( 7201): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-11 21:02:12.870+0800 I/APP_CORE( 7201): appcore-efl.c: __do_app(453) > [APP 7201] Event: RESET State: CREATED
07-11 21:02:12.870+0800 I/CAPI_APPFW_APPLICATION( 7201): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
07-11 21:02:12.890+0800 I/APP_CORE( 7201): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
07-11 21:02:12.890+0800 I/APP_CORE( 7201): appcore-efl.c: __do_app(524) > [APP 7201] Initial Launching, call the resume_cb
07-11 21:02:12.895+0800 I/CAPI_APPFW_APPLICATION( 7201): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
07-11 21:02:12.905+0800 W/W_HOME  (  807): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
07-11 21:02:12.905+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 21:02:12.905+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 21:02:12.910+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 21:02:12.910+0800 W/W_HOME  (  807): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
07-11 21:02:12.910+0800 W/W_INDICATOR(  755): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-11 21:02:12.910+0800 W/W_INDICATOR(  755): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-11 21:02:12.940+0800 W/APP_CORE( 7201): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3400002
07-11 21:02:12.950+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e9728 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-11 21:02:12.950+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e9728 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
07-11 21:02:12.990+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e9728 : elm_genlist] mx(0), my(260), minx(0), miny(0), px(0), py(0)
07-11 21:02:12.990+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e9728 : elm_genlist] cw(360), ch(620), pw(360), ph(360)
07-11 21:02:13.075+0800 W/W_HOME  (  807): event_manager.c: _window_visibility_cb(466) > Window [0x2E00003] is now visible(1)
07-11 21:02:13.075+0800 W/W_HOME  (  807): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
07-11 21:02:13.075+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 21:02:13.075+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 21:02:13.075+0800 W/W_HOME  (  807): main.c: _window_visibility_cb(963) > Window [0x2E00003] is now visible(1)
07-11 21:02:13.080+0800 I/APP_CORE(  807): appcore-efl.c: __do_app(453) > [APP 807] Event: PAUSE State: RUNNING
07-11 21:02:13.080+0800 I/CAPI_APPFW_APPLICATION(  807): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-11 21:02:13.080+0800 W/W_HOME  (  807): main.c: _appcore_pause_cb(487) > appcore pause
07-11 21:02:13.080+0800 W/W_HOME  (  807): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
07-11 21:02:13.080+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 21:02:13.085+0800 W/W_INDICATOR(  755): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-11 21:02:13.090+0800 W/AUL     (  522): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(807) status(bg) type(uiapp)
07-11 21:02:13.090+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[807] goes to (4)
07-11 21:02:13.090+0800 E/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 807)'s state(4)
07-11 21:02:13.100+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[7201] goes to (3)
07-11 21:02:13.100+0800 W/W_INDICATOR(  755): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-11 21:02:13.110+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 21:02:13.110+0800 W/W_HOME  (  807): main.c: home_pause(546) > clock/widget paused
07-11 21:02:13.110+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 21:02:13.110+0800 I/APP_CORE( 7201): appcore-efl.c: __do_app(453) > [APP 7201] Event: RESUME State: RUNNING
07-11 21:02:13.115+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-11 21:02:13.115+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-11 21:02:13.115+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-11 21:02:13.115+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-11 21:02:13.115+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-11 21:02:13.115+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-11 21:02:13.115+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-11 21:02:13.115+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-11 21:02:13.115+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-11 21:02:13.115+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-11 21:02:13.115+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-11 21:02:13.115+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-11 21:02:13.115+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-11 21:02:13.115+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-11 21:02:13.115+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-11 21:02:13.115+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-11 21:02:13.115+0800 W/AUL_AMD (  522): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-11 21:02:13.115+0800 W/AUL_AMD (  522): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
07-11 21:02:13.115+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-11 21:02:13.115+0800 W/AUL     (  522): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.sensordatacollection) pid(7201) status(fg) type(uiapp)
07-11 21:02:13.115+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-11 21:02:13.115+0800 E/CAPI_APPFW_APP_CONTROL( 1014): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-11 21:02:13.115+0800 W/MUSIC_CONTROL_SERVICE( 1014): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1014]   [com.samsung.w-home]register msg port [false][0m
07-11 21:02:13.120+0800 I/wnotib  (  807): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
07-11 21:02:13.120+0800 E/wnotib  (  807): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-11 21:02:13.120+0800 W/wnotib  (  807): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
07-11 21:02:13.140+0800 W/SHealthCommon(  937): SHealthMessagePortConnection.cpp: Send(512) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
07-11 21:02:13.140+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-11 21:02:13.140+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-11 21:02:13.140+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-11 21:02:13.140+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-11 21:02:13.140+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-11 21:02:13.140+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-11 21:02:13.140+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
07-11 21:02:13.140+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-11 21:02:13.140+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-11 21:02:13.140+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-11 21:02:13.140+0800 W/SHealthCommon( 1108): SHealthMessagePortConnection.cpp: OnPortMessageReceived(135) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
07-11 21:02:13.150+0800 I/CAPI_WIDGET_APPLICATION(  937): widget_app.c: __provider_pause_cb(298) > widget obj was paused
07-11 21:02:13.150+0800 W/AUL     (  937): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.shealth.widget.pedometer) pid(937) status(bg) type(widgetapp)
07-11 21:02:13.155+0800 I/CAPI_WIDGET_APPLICATION(  937): widget_app.c: __check_status_for_cgroup(145) > enter background group
07-11 21:02:13.470+0800 E/AUL     (  522): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-11 21:02:13.625+0800 I/APP_CORE(  807): appcore-efl.c: __do_app(453) > [APP 807] Event: MEM_FLUSH State: PAUSED
07-11 21:02:13.960+0800 E/EFL     ( 7201): ecore_x<7201> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5717927 button=1
07-11 21:02:13.960+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] mouse move
07-11 21:02:13.975+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] mouse move
07-11 21:02:13.975+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] hold(0), freeze(0)
07-11 21:02:13.980+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] mouse move
07-11 21:02:13.980+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] hold(0), freeze(0)
07-11 21:02:14.015+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] mouse move
07-11 21:02:14.015+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] hold(0), freeze(0)
07-11 21:02:14.040+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4292 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] add hold animator
07-11 21:02:14.040+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] mouse move
07-11 21:02:14.045+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] hold(0), freeze(0)
07-11 21:02:14.045+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] mouse move
07-11 21:02:14.045+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] hold(0), freeze(0)
07-11 21:02:14.045+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x417e9728 : elm_genlist] direction_x(0), direction_y(1)
07-11 21:02:14.045+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x417e9728 : elm_genlist] drag_child_locked_y(0)
07-11 21:02:14.045+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x417e9728 : elm_genlist] move content x(0), y(158)
07-11 21:02:14.070+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 14
07-11 21:02:14.080+0800 W/AUL_AMD (  522): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7201
07-11 21:02:14.085+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 12
07-11 21:02:14.100+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 14
07-11 21:02:14.110+0800 E/EFL     ( 7201): ecore_x<7201> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5718045 button=1
07-11 21:02:14.110+0800 W/AUL_AMD (  522): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7201
07-11 21:02:14.110+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] mouse move
07-11 21:02:14.110+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 12
07-11 21:02:14.115+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] hold(0), freeze(0)
07-11 21:02:14.115+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] mouse move
07-11 21:02:14.115+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] hold(0), freeze(0)
07-11 21:02:14.115+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] mouse move
07-11 21:02:14.115+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] hold(0), freeze(0)
07-11 21:02:14.115+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] mouse move
07-11 21:02:14.115+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] hold(0), freeze(0)
07-11 21:02:14.115+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] mouse move
07-11 21:02:14.115+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] hold(0), freeze(0)
07-11 21:02:14.380+0800 I/AUL_PAD ( 7302): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-11 21:02:14.765+0800 E/EFL     ( 7201): ecore_x<7201> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5718719 button=1
07-11 21:02:14.770+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] mouse move
07-11 21:02:14.800+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] mouse move
07-11 21:02:14.800+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] hold(0), freeze(0)
07-11 21:02:14.825+0800 E/EFL     ( 7201): ecore_x<7201> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5718794 button=1
07-11 21:02:14.825+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] mouse move
07-11 21:02:14.825+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] hold(0), freeze(0)
07-11 21:02:14.825+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] mouse move
07-11 21:02:14.825+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e9728 : elm_genlist] hold(0), freeze(0)
07-11 21:02:15.085+0800 I/efl-extension( 7201): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-11 21:02:15.085+0800 I/efl-extension( 7201): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x417fc3f8, elm_image, _activated_obj : 0x44509920, activated : 1
07-11 21:02:15.090+0800 I/efl-extension( 7201): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-11 21:02:15.110+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447a90c0 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-11 21:02:15.110+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447a90c0 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-11 21:02:15.125+0800 E/EFL     ( 7201): elementary<7201> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-11 21:02:15.135+0800 E/EFL     ( 7201): elementary<7201> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x4479ddb0) will be pushed
07-11 21:02:15.135+0800 I/efl-extension( 7201): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44d36210]'s widget[0x44d2d190] to layout widget[0x4479ddb0]
07-11 21:02:15.140+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447a90c0 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-11 21:02:15.140+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447a90c0 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-11 21:02:15.140+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447a90c0 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-11 21:02:15.145+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447a90c0 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-11 21:02:15.145+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447a90c0 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-11 21:02:15.145+0800 E/EFL     ( 7201): elementary<7201> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447a90c0 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-11 21:02:15.145+0800 I/efl-extension( 7201): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-11 21:02:15.175+0800 E/EFL     ( 7201): elementary<7201> elc_naviframe.c:2796 _push_transition_cb() item(0x4479ddb0) will transition
07-11 21:02:15.425+0800 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-11 21:02:15.595+0800 E/EFL     ( 7201): elementary<7201> elc_naviframe.c:1193 _on_item_push_finished() item(0x44509d88) transition finished
07-11 21:02:15.600+0800 E/EFL     ( 7201): elementary<7201> elc_naviframe.c:1218 _on_item_show_finished() item(0x4479ddb0) transition finished
07-11 21:02:18.130+0800 I/APP_CORE(  807): appcore-efl.c: __do_app(453) > [APP 807] Event: MEM_FLUSH State: PAUSED
07-11 21:02:18.610+0800 E/EFL     ( 7201): ecore_x<7201> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5722579 button=1
07-11 21:02:18.665+0800 E/EFL     ( 7201): ecore_x<7201> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5722634 button=1
07-11 21:02:18.665+0800 E/EFL     ( 7201): elementary<7201> elm_widget.c:4382 elm_widget_type_check() Passing Object: 0x447a8f48 in function: elm_naviframe_item_pop, of type: 'rectangle' when expecting type: 'elm_naviframe'
07-11 21:02:28.205+0800 W/SHealthCommon( 1108): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1499731200000.000000[0;m
07-11 21:02:28.255+0800 W/SHealthCommon( 1108): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
07-11 21:02:28.270+0800 I/HealthDataService(  998): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-11 21:02:28.300+0800 I/healthData( 1108): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-11 21:02:29.960+0800 W/WATCH_CORE(  934): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
07-11 21:02:29.960+0800 I/WATCH_CORE(  934): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
07-11 21:02:29.960+0800 I/CAPI_WATCH_APPLICATION(  934): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 21:02:29.960+0800 E/watchface-loader(  934): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 21:02:29.960+0800 I/watchface-loader(  934): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
07-11 21:02:29.975+0800 E/wnoti-service( 1055): wnoti-db-utility.c: context_wearonoff_status_cb(1774) > status changed from 1 to 2 
07-11 21:02:29.980+0800 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23423) > wear_monitor_status update[0] = 1 -> 2
07-11 21:02:29.990+0800 W/WECONN  (  502): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_OFF
07-11 21:02:29.990+0800 W/WECONN  (  502): <__wc_device_on_wear_onoff_changed_cb:354> { state=WC_FEATURE_STATE_OFF
07-11 21:02:29.990+0800 W/WECONN  (  502): <__wc_device_on_wear_onoff_changed_cb:385> }
07-11 21:02:29.990+0800 W/WECONN  (  502): <__wc_feature_wearonoff_monitor_cb:531> }
07-11 21:02:30.050+0800 W/SHealthService( 1108): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1008[0;m
07-11 21:02:32.350+0800 E/RESOURCED(  630): block-monitor.c: block_logging(123) > pid 7201(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/acc/2017-07-11-21-0-2-acc.txt
07-11 21:02:32.355+0800 E/RESOURCED(  630): block-monitor.c: block_logging(123) > pid 7201(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/gyr/2017-07-11-21-0-2-gyr.txt
07-11 21:02:32.815+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[807] goes to (3)
07-11 21:02:32.815+0800 E/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 807)'s state(3)
07-11 21:02:32.815+0800 W/AUL_AMD (  522): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-11 21:02:32.815+0800 W/AUL_AMD (  522): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
07-11 21:02:32.815+0800 W/AUL     (  522): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(807) status(fg) type(uiapp)
07-11 21:02:32.845+0800 I/MALI    (  807): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43ecf218] swap changed from sync to async
07-11 21:02:32.895+0800 W/AUL_PAD ( 1295): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 7201 pgid = 7201
07-11 21:02:32.895+0800 W/AUL_PAD ( 1295): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
07-11 21:02:32.900+0800 E/RESOURCED(  630): block-monitor.c: block_logging(123) > pid 7201(37183 10l) accessed /opt/usr/media/Downloads/yfchen_sensor_data/acc/2017-07-11-21-0-2-acc.txt
07-11 21:02:32.900+0800 E/RESOURCED(  630): block-monitor.c: block_logging(123) > pid 7201(37183 10l) accessed /opt/usr/media/Downloads/yfchen_sensor_data/gyr/2017-07-11-21-0-2-gyr.txt
07-11 21:02:32.910+0800 W/CRASH_MANAGER( 7340): worker.c: worker_job(1205) > 110720173656e149977815