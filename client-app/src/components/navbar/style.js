import styled from 'styled-components';
import { FlexRow } from '../globals';

export const Nav = styled.nav`
    position: fixed;
    top: 0;
    width: 100%;
    z-index: 100;
    height: 60px;
    background-color: #ffffff;
    box-shadow: 0px 6px 10px rgba(131, 134, 163, 0.12);

    ul {
        margin: 0;
        padding: 0;
        list-style: none;
        overflow: hidden;
        background-color: #fff;
        clear: both;
        max-height: 0;
        transition: max-height 0.2s ease-out;
        box-shadow: 0px 6px 10px rgba(131, 134, 163, 0.12);

        li a {
            display: block;
            padding: 20px 20px;
            border-right: 1px solid #f4f4f4;
            text-decoration: none;

            :hover {
                background-color: #f4f4f4;
            }
        }

        @media (min-width: 992px) {
            max-height: none;
            clear: none;
            float: right;
            box-shadow: none;

            li {
                float: left;
            }
        }
    }
`;

export const Logo = styled.div`
    display: flex;
    align-items: center;
    height: 100%;
    padding-left: 15px;
    float: left;
`;

export const ToggleWrapper = styled.label`
    cursor: pointer;
    float: right;
    padding: 28px 20px;
    position: relative;
    user-select: none;

    @media (min-width: 992px) {
        display: none;
    }
`;

export const ToggleIcon = styled.span`
    background: #333;
    display: block;
    height: 2px;
    position: relative;
    transition: background 0.2s ease-out;
    width: 18px;

    &:before,
    &:after {
        background: #333;
        content: '';
        display: block;
        height: 100%;
        position: absolute;
        transition: all 0.2s ease-out;
        width: 100%;
    }

    &:before {
        top: 5px;
    }

    &:after {
        top: -5px;
    }
`;

export const ToggleInput = styled.input`
    display: none;

    &:checked + ${ToggleWrapper} > ${ToggleIcon} {
        background: transparent;
    }

    &:checked + ${ToggleWrapper} > ${ToggleIcon}:before {
        transform: rotate(-45deg);
    }

    &:checked + ${ToggleWrapper} > ${ToggleIcon}:after {
        transform: rotate(45deg);
    }

    &:checked + ${ToggleWrapper}:not(.steps) > ${ToggleIcon}:before {
        top: 0;
    }

    &:checked + ${ToggleWrapper}:not(.steps) > ${ToggleIcon}:after {
        top: 0;
    }

    &:checked ~ ul {
        max-height: 240px;
    }
`;
