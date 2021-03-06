﻿/// <summary>
/// Copyright (c) 2016 Fredric Baeckström Arklid
/// All rights reserved.
/// 
/// THIS SOFTWARE IS PROVIDED "AS IS" AND ANY EXPRESSED OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS
/// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE REGENTS OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR 
/// CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
/// 
/// HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
/// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
/// 
/// 0101010001101000011001010111001001100101001000000110100101110011001000000110111001101111001000000111001101110000011011110110111101101110
/// </summary>
namespace GameSecurityResearch.Cryptography
{
    public static class Forza3Crypto
    {
        //@Todo: Add decrypt and encrypt methods.
        private static readonly byte[] AESKey = { 0x27, 0x50, 0x37, 0x9D, 0x34, 0x8C, 0x47, 0xAE, 0x09, 0x5A, 0xA3, 0xC4, 0x71, 0xB1, 0x2E, 0xD4 };
        private static readonly byte[] HMACKey1 = { 0x8F, 0xF6, 0x54, 0xFC, 0x40, 0x64, 0x6A, 0x75, 0x68, 0x8D, 0xEE, 0xE8, 0x9E, 0x24, 0x58, 0x58 };
        private static readonly byte[] HMACKey2 = { 0x28, 0x05, 0x70, 0xC8, 0x8B, 0xE6, 0x26, 0xEF, 0x83, 0x94, 0xFF, 0x6A, 0xE2, 0x96, 0x04, 0x3A };
        private static readonly byte[] HMACKey3 = { 0xA5, 0x0B, 0x3A, 0x0B, 0x0B, 0xEB, 0xBB, 0x8E, 0x77, 0xDE, 0xC2, 0x75, 0x5C, 0xE6, 0x00, 0x33 };
    }
}
