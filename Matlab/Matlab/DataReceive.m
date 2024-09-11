clear all;
close all;
instrreset;
disp('Press Ctrl+C to stop collecting data!')              %��Ctrl+C,��ֹ���ݵĻ�ȡ
s=serial('com8','baudrate',9600) ;fopen(s) ;               %�뽫COM44���ɵ���ʶ�𵽵�COM�ڣ�������9600���ɴ�������Ӧ�Ĳ�����    Please replace COM44 with the COM port recognized by the PC, and change the baud rate 9600 to the baud rate corresponding to the sensor
f = 20;         %DataFrequce
t=0;
cnt = 1;
aa=[0 0 0];     %���ٶ�XYZ    Acceleration X, Y, Z axis
ww=[0 0 0];     %���ٶ�XYZ    Angular velocity X, Y, Z axis
AA = [0 0 0];   %�Ƕ�XYZ      Angle X, Y, Z axis
tt = 0;
a=[0 0 0]';
w=[0 0 0]';
A=[0 0 0]';
while(1)
    Head = fread(s,2,'uint8');                              %��ȡ�������ݣ�����s�ļ����Ѿ��������ἰ��  Getting serial data, the S file has been mentioned above
    if (Head(1)~=uint8(85))                                 %������ڵĵ�һ�����ݲ�����85(0x55)��֤��������Э�飬���������ݽ���  If the first data of the serial is not equal to 85 (0x55), it proves that it isn't conform to the protocol and haven't perform data analysis
        continue;
    end   
    Head(2)
    switch(Head(2))                                         %��ȡ���ڵڶ�������   Getting the second data of the serial
        case 81                                             %81(0x51):���ٶȰ�   81(0x51): Acceleration data packet
            a = fread(s,3,'int16')/32768*16;                %��ȡ3��16bit�ļ��ٶ����ݣ���ο�Э��˵��   Getting three 16bit acceleration data, please refer to the protocol
        case 82                                             %82(0x52):���ٶȰ�   82 (0x52): Angular velocity data packet
            w = fread(s,3,'int16')/32768*2000;              %��ȡ3��16bit�Ľ��ٶ����ݣ���ο�Э��˵��   Getting three 16bit angular velocity data, please refer to the protocol
        case 83                                             %83(0x53):�ǶȰ�     83 (0x53): Angular data packet
            A = fread(s,3,'int16')/32768*180;               %��ȡ3��16bit�ĽǶ����ݣ���ο�Э��˵��     Getting three 16bit angle data, please refer to the protocol.
            aa = [aa;a'];
            ww = [ww;w'];
            AA = [AA;A'];
            tt = [tt;t];
            
            subplot(3,1,1);plot(tt,aa);title(['Acceleration = ' num2str(a') 'm2/s']);ylabel('m2/s');
            subplot(3,1,2);plot(tt,ww);title(['Gyro = ' num2str(w') '��/s']);ylabel('��/s');
            subplot(3,1,3);plot(tt,AA);title(['Angle = ' num2str(A') '��']);ylabel('��');              
            cnt=0;
            drawnow;
            if (size(aa,1)>5*f)                              %�����ʷ����   Clear history data
                aa = aa(f:5*f,:);
                ww = ww(f:5*f,:);
                AA = AA(f:5*f,:);
                tt = tt(f:5*f,:);
            end
            t=t+0.1;                                         %����Ĭ����10Hz��Ҳ����0.1s����������˲�Ʒ��������ʣ����0.1��Ϊ�����������   The data default is 10Hz, which is 0.1s. If you change the output rate of the product, please change 0.1 to other output rates
    end 
        
            End = fread(s,3,'uint8');
end
fclose(s);